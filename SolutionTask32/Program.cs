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

//Меняем знак значений массива
int[] CalculateTask (int[] arr) {
    int i = 0;  
    int[] array = new int[arr.Length];

    foreach(int value in arr) {
        array[i] = value * (-1);
        i++;
    }
    return array;
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

int[] intArr = GenArray();
int[] calculateArr = CalculateTask(intArr);
Print(intArr);
Print(calculateArr);