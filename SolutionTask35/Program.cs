System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray () {
    int i = 0;
    int n = 123;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(0, 1000);
        i++;
    }

    return array;
}

//Считаем количество элементов входящих в диапазон
int CalculateTask (int[] arr, int downBorder, int upBorder) {
    int i = 0;  
    int resultCount = 0;

    while (i < arr.Length) {
        if(arr[i] >= downBorder && arr[i] <= upBorder) {
           resultCount++;
        }        
        i++;
    }
    return resultCount;
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

int downBorder = 10;
int upBorder = 99;
int[] intArr = GenArray();
Print(intArr);
int countRes = CalculateTask(intArr, downBorder, upBorder);
Console.Write($"Элементов между {downBorder} и {upBorder} равно {countRes}");