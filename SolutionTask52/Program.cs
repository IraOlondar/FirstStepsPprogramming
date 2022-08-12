/**
* Создание двумерного массива. Нахождение средннего арифметического по диагоналям и диагонали выделить разным цветом.
*
*/

using System;
using static System.Math;

System.Random numberSintezator = new Random();

//Генерируем массив
long[,] GenTwoDimensionalArray (int m, int n, int min, int max) {
    int i = 0, j = 0;
    long[,] array = new long[m, n];

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


//Создание массива разметки главных диагоналей матрицы
string[] IndexDownLeftTwoArray (long[,] arr) {
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int i = 0;
    int j = 0;
    int startCol;
    int count;
    string[] indexses = new string[row + col - 1];

    while (i < (row + col - 1)) {
        indexses[i] = "";
        startCol = Max(0, i + 1 - row);
        count = Min(i + 1, Math.Min((col - startCol), row));
        j = 0;
        while (j < count) {
            indexses[i] += (Min(row, i + 1) - j - 1) + ";" + (startCol + j) + (j != count - 1 ? "--" : "");
            j++;
        }
        i++;
    }

    return indexses;
}

//Создание массива разметки побочных диагоналей матрицы
string[] IndexDownRightTwoArray (long[,] arr) {
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int i = 0;
    int j = 0;
    int startCol;
    int count;
    long val;
    string[] indexses = new string[row + col - 1];

    while (i < (row + col - 1)) {
        indexses[i] = "";
        startCol = Max(0, i + 1 - row);
        count = Min(i + 1, Math.Min((col - startCol), row));
        j = 0;
    
        while (j < count) {
            val = arr[Max(0, row - 1 - i) + j, startCol + j];
            indexses[i] += (Max(0, row - 1 - i) + j) + ";" + (startCol + j) + (j != count - 1 ? "--" : "");
            j++;
        }
        i++;
    }

    return indexses;
}

//Среднее арифметическое главных диагоналей матрицы
double[] DiagDownLeftTwoArray (long[,] arr) {
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int i = 0;
    int j = 0;
    int startCol;
    int count;
    long val;
    double[] ans = new double[row + col - 1];

    while (i < (row + col - 1)) {
        ans[i] = 0;
        startCol = Max(0, i + 1 - row);
        count = Min(i + 1, Math.Min((col - startCol), row));
        j = 0;
        while (j < count) {
            val = arr[Min(row, i + 1) - j - 1, startCol + j];
            ans[i] += val;
            j++;
        }
        ans[i] = Math.Round(ans[i] / count, 2);
        i++;
    }

    return ans;
}

//Среднее арифметическое побочных диагоналей матрицы
double[] DiagDownRightTwoArray (long[,] arr) {
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int i = 0;
    int j = 0;
    int startCol;
    int count;
    long val;
    double[] ans = new double[row + col - 1];

    while (i < (row + col - 1)) {
        ans[i] = 0;
        startCol = Max(0, i + 1 - row);
        count = Min(i + 1, Math.Min((col - startCol), row));
        j = 0;
    
        while (j < count) {
            val = arr[Max(0, row - 1 - i) + j, startCol + j];
            ans[i] += val;
            j++;
        }
        ans[i] = Math.Round(ans[i] / count, 2);
        i++;
    }

    return ans;
}

//Вывод на печать матрицы с цветными диагоналями
void PrintColorTwoDimensionalArray (long[,] arr, string[] str) {
    int i = 0;
    int j = 0;
    int s = 0;
    int isColor = -1;
    int[] ar = new int[2];
    Console.WriteLine();
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            Console.Write(new string(' ', 5 - arr[i,j].ToString().Length));
            s = 0;
            isColor = -1;
            str.ToList().ForEach(x => {
                s = s <= 14 ? s : s - 14;
                x.Split("--").ToList().ForEach(d => {
                    ar = d.Split(";").Select(x => int.Parse(x)).ToArray();
                    if (i == ar[0] && j == ar[1]) isColor = s;
                });
                s++;
            });

            if (isColor >= 0) {
                Console.ForegroundColor = (ConsoleColor)(isColor + 1);
                Console.Write(arr[i,j]);
                Console.ResetColor();
            } else {
                Console.Write(arr[i,j]);
            }
            Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}

//Выводим на печать массива среднего арифметического диагоналей массива
void PrintArray (double[] arr , string str) {
    int i = 0;
    int s = 0;
   Console.WriteLine(str);
    while(i < arr.Length) {
        s = s <= 14 ? s : s - 14;
        Console.ForegroundColor = (ConsoleColor)(s + 1);
        Console.Write(arr[i] + (i != arr.Length - 1 ? " " : ""));
        Console.ResetColor();
        i++;
        s++;
    }
    Console.WriteLine();
}


int maxIndexA = 10;
int maxIndexB = 10;

//GenTwoDimensionalArray(M, N, ОТ, ДО);
long[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(maxIndexA, maxIndexB, 0, 1000);

string[] arsRight = IndexDownRightTwoArray(intArrTwoDimensionalArray);
PrintColorTwoDimensionalArray(intArrTwoDimensionalArray, arsRight);
double[] newArrDiagDownRightTwoArray = DiagDownRightTwoArray(intArrTwoDimensionalArray);
PrintArray(newArrDiagDownRightTwoArray, "Среднее арифметическое главных диагоналей:");

string[] arsLeft = IndexDownLeftTwoArray(intArrTwoDimensionalArray);
PrintColorTwoDimensionalArray(intArrTwoDimensionalArray, arsLeft);
double[] newArrDiagDownLeftTwoArray = DiagDownLeftTwoArray(intArrTwoDimensionalArray);
PrintArray(newArrDiagDownLeftTwoArray, "Среднее арифметическое побочных диагоналей:");

