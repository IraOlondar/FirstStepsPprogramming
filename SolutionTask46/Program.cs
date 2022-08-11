/**
* Создание двумерного массива размером m×n,
заполненный случайными целыми числами
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


//Выводим на печать массив
void PrintTwoDimensionalArray (int[,] arr) {
    int i = 0, j = 0;
    Console.WriteLine("Массив:");
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            Console.Write(arr[i,j] + (j != arr.GetLength(1) - 1 ? "\t" : ""));
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}

//Выводим на печать массив
void PrintTwoDimensionalArrayColor (int[,] arr) {
    int i = 0, j = 0;
    Console.WriteLine("Массив:");
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            Console.Write(arr[i,j] + (j != arr.GetLength(1) - 1 ? "\t" : ""));
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}


//GenTwoDimensionalArray(M, N, ОТ, ДО);
int[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(10, 5, 0, 100);
PrintTwoDimensionalArray(GenTwoDimensionalArray(10, 5, 0, 100));
PrintTwoDimensionalArrayColor(GenTwoDimensionalArray(10, 5, 0, 100));