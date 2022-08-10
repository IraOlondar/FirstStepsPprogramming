/**
* Переворот массива
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray (int n, int min, int max) {
    int i = 0;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(min, max);
        i++;
    }

    return array;
}

//Разворачиваем массив, создавая новый
int[] ReversArrayNew (int[] arr) {
    int i = 0;  
    int[] newArray = new int[arr.Length];
    while(i < newArray.Length) {
       newArray[i] = arr[arr.Length - 1 - i];
       i++;
    }
    return newArray;
}

//Меняем местами елементы массива по индексу
void Swap (int[] arr, int a, int b) {
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

//Разворачиваем существующий массив
void ReversArray (int[] arr) {
    int i = 0;

    while(i < arr.Length / 2 - 1) {
       Swap(arr, i, arr.Length - i - 1);
       i++;
    }
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

int[] intArr = GenArray(13, 0, 10);
int[] calculateArr = ReversArrayNew(intArr);
Print(intArr);
Print(calculateArr);
ReversArray(intArr);
Print(intArr);
