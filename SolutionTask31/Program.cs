System.Random numberSintezator = new Random();

int summMinus = 0;
int summPlus = 0;

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

//Суммируем отрицательные и положительные
void Summ (int[] arr) {
    int i = 0;  

    foreach(int value in arr) {
        if (value < 0)
            summMinus += value;

        if (value > 0)
            summPlus += value;

        i++;
    }
}

//Выводим на печать массив, суммируем отрицательные и положительные значения
void Print (int[] arr, int sMinus, int sPlus) {
    int i = 0;
    
    Console.Write("[");
    foreach(int value in arr) {
        Console.Write(value + (i != arr.Length ? "," : ""));
        i++;
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Сумма отрицательных чисел: {sMinus}");
    Console.WriteLine($"Сумма положительных чисел: {sPlus}");
}

//Генерируем массив, выводим его на печать на печать массив, суммируем отрицательные и положительные значения
void VariantNaive () {
    int i = 0;
    int n = 12;
    int value;
    int summMinus = 0;
    int summPlus = 0;
    
    Console.Write("[");
    while (i < n) {
        value = numberSintezator.Next(-9, 9);
        if (value < 0)
            summMinus += value;
        
        if (value > 0)
            summPlus += value;

        Console.Write(value + (i != n ? "," : ""));
        i++;
    }
    Console.Write(numberSintezator.Next(0, 2));
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Сумма отрицательных чисел: {summMinus}");
    Console.WriteLine($"Сумма положительных чисел: {summPlus}");
}

DateTime timePoint;

timePoint = DateTime.Now;
int[] intArr = GenArray();
Summ(intArr);
Print(intArr, summMinus, summPlus);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
VariantNaive();
Console.WriteLine(DateTime.Now - timePoint);