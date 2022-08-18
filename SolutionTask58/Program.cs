/**
* Создание двумерного массива. 
* Нахождение произведения двух матриц.
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

//Произведение двух матриц
int[,] СompositionTwoDimensionalArrays (int[,] arrA, int[,] arrB) {
    int[,] resultArray = new int[arrA.GetLength(0), arrB.GetLength(1)];

    for (int i = 0; i < arrA.GetLength(0); i++) {
        for (int j = 0; j < arrB.GetLength(1); j++) {
            for (int k = 0; k < arrB.GetLength(0); k++) {
                resultArray[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
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


//GenTwoDimensionalArray(M, N, ОТ, ДО);
int[,] intArrTwoDimensionalArrayFirst = GenTwoDimensionalArray(3, 4, 0, 10);
int[,] intArrTwoDimensionalArraySecond = GenTwoDimensionalArray(4, 3, 0, 10);

PrintTwoDimensionalArray(intArrTwoDimensionalArrayFirst);
PrintTwoDimensionalArray(intArrTwoDimensionalArraySecond);

if (intArrTwoDimensionalArrayFirst.GetLength(1) == intArrTwoDimensionalArraySecond.GetLength(0)) {
    PrintTwoDimensionalArray(СompositionTwoDimensionalArrays(intArrTwoDimensionalArrayFirst, intArrTwoDimensionalArraySecond));
} else {
    Console.WriteLine("Матрицы нельзя перемножать!");
}
