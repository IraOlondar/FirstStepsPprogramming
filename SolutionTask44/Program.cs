/**
* Вывод первых N чисел Фибоначчи
*
*/

//Читаем консоль
int ReadSieds () {
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine() ?? "");
}

//Вывод первых N чисел Фибоначчи
string CalculateTask (int n) {
    if (n == 1) return "0";
    else if (n == 2) return "1, 2";
    else {
        string result = "0, 1"; 
        int f_1 = 0;
        int f_2 = 1;
        
        for (int i = 0; i < n - 1; i++) {
            int fn = f_1 + f_2;
            result += ", " + fn;
            f_1 = f_2;
            f_2 = fn;
        }

        return result;
    }
}

//Выводим результат
void Print (string num) {
    Console.WriteLine($"Ряд Фибоначчи: {num}");
}

Print(CalculateTask(ReadSieds()));