System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray () {
    int i = 0;
    int n = 124;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(-1000, 1000);
        i++;
    }

    return array;
}

//Считаем количество элементов
int[] CalculateTask (int[] arr) {
    int i = 0;  
    int[] newArray = new int[arr.Length / 2 + 1];
    while(i < newArray.Length) {
       newArray[i] = arr[i] * arr[arr.Length - 1 - i];
       i++;
    }
    return newArray;
}

//Выводим на печать массив
void Print (int[] arr) {
    int i = 0;
    
    Console.Write("[");
    foreach(int value in arr) {
        Console.Write(value + (i != arr.Length - 1 ? "," : ""));
        i++;
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] intArr = GenArray();
int[] calculateArr = CalculateTask(intArr);
Print(intArr);
Print(calculateArr);