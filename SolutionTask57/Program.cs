/**
* Создание двумерного массива. 
* Создание частотного словаря элементов двумерного массива.
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
int[,] GenTwoDimensionalArray (int m, int n, int min, int max) {
    int i = 0, j = 0;
    int[,] array = new int[m, n];

    while (i < m) {
        j = 0;
        while (j < n) {
            array[i,j] = numberSintezator.Next(min, max);
            j++;
        }
        i++;
    }

    return array;
}

//Создаем словарь частоты появления элементов
int[] UpdateTwoDimensionalArray (int[,] arr) {
    int i = 0;
    int j = 0;
    int[] resultArray = new int[100];
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            resultArray[arr[i,j]]++;
            j++;
        }
        i++;
    }
    return resultArray;
}


//Выводим на печать двумерный массив
void PrintTwoDimensionalArray (int[,] arr) {
    int i = 0, j = 0;
    Console.WriteLine();
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            Console.Write(new string(' ', 3 - arr[i,j].ToString().Length));
            Console.Write(arr[i,j] + (j != arr.GetLength(1) - 1 ? " " : ""));   
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}

//Выводим на печать массив
void Print (int[] arr) {
    int i = 0;
    foreach(int value in arr) {
        Console.Write(i + ":" + value + (i != arr.Length - 1 ? "  " : ""));
        i++;
    }
    Console.WriteLine();
}


//GenTwoDimensionalArray(M, N, ОТ, ДО);
int[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(30, 30, 0, 100);
PrintTwoDimensionalArray(intArrTwoDimensionalArray);

Print(UpdateTwoDimensionalArray(intArrTwoDimensionalArray));

