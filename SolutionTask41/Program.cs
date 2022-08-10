/**
* Вводим сколько чисел больше 0 было введено
*
*/

//Читаем консоль
int ReadSieds () {
    Console.Write("Введите ожидаемое количество чисел: ");
   
    //Список цифровых клавиш
    string[] keyArray = {
        "D0","D1","D2","D3","D4","D5","D6","D7","D8","D9",
        "NumPad0","NumPad1","NumPad2","NumPad3","NumPad4","NumPad5","NumPad6","NumPad7","NumPad8","NumPad8"
    };

    int countNumber =  int.Parse(Console.ReadLine() ?? "");
    int x = 0;
    string stringRes = "";
    int count = 0;
    Console.WriteLine("Введите числа, нажимая Enter после каждого числа!");
    while (x < countNumber) {

        string? inputStrin = Console.ReadKey(true).Key.ToString();
       
        if (inputStrin == "OemMinus" && stringRes.Length == 0) {
            stringRes = "-";
            Console.Write(stringRes);
        } else if (Array.IndexOf(keyArray, inputStrin) != -1) {
            inputStrin = inputStrin.Replace("D", "").Replace("NumPad", "");
            stringRes += inputStrin;
            Console.Write(inputStrin);
        } else if (inputStrin == "Backspace" && stringRes.Length > 0) {
            stringRes = stringRes.Remove(stringRes.Length - 1);
            Console.Write("\b \b");
        } else if (inputStrin == "Enter" && stringRes.Replace("-", "").Length > 0) {
            Console.WriteLine();
            if (int.Parse(stringRes) > 0) count++;
            stringRes = "";
            x++;
        }
    }

    return count;
}

//Выводим на печать количества чисел больше нуля
void Print (int c) {
    Console.WriteLine($"Веедено чисел больше нуля: {c}");
}


Print(ReadSieds());

