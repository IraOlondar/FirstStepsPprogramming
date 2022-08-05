System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray () {
    int i = 0;
    int n = 12;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(-9, 9);
        i++;
    }

    return array;
}

//Проверяем наличие числа в массиве
void CalculateTask (int numSarch, int[] arr) {
    string resultSearch = "нет";
    foreach(int value in arr) {
        if (value == numSarch) {
            resultSearch = "есть";
            break;
        }
    }
    Console.WriteLine(resultSearch);
}

//Выводим на печать массив
void Print (int[] arr) {
    int i = 0;
    
    Console.Write("[");
    foreach(int value in arr) {
        Console.Write(value + (i != arr.Length ? "," : ""));
        i++;
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
int inputNumber = int.Parse(input);

if (input != "") {
    int[] intArr = GenArray();
    Print(intArr);
    CalculateTask(inputNumber, intArr);
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}
