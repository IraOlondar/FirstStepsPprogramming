/**
* Создание двумерного массива. 
* Удаление строки и столбца, на пересечении которых 
* расположен наименьший элемент массива.
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

//Находжение индексов нименьшего числа
int[] SerchTwoDimensionalArray (int[,] arr) {
    int i = 0;
    int j = 0;
    int iMin = 0;
    int jMin = 0;
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            if (arr[iMin,jMin] > arr[i,j]) {
                iMin = i;
                jMin = j;
            }
            j++;
        }
        i++;
    }
    return new int[]{iMin,jMin};
}

//Удаление из массива i-й строки и j-го столбца
int[,] UpdateTwoDimensionalArray (int[,] arr, int x, int y) {
    int i = 0;
    int j = 0;
    int ii = 0;
    int jj = 0;
    int[,] resultArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    while(i < arr.GetLength(0)) {
        j = 0;
        jj = 0;
        while(j < arr.GetLength(1)) {
            if (j != y && i != x) {
                resultArray[ii,jj] = arr[i,j];
            }
            j++;
            if (j != y) jj++;
        }
        i++;
        if (i != x) ii++;
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
        Console.Write(value + (i != arr.Length - 1 ? "  " : ""));
        i++;
    }
    Console.WriteLine();
}


//GenTwoDimensionalArray(M, N, ОТ, ДО);
int[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(10, 10, 0, 1000);
PrintTwoDimensionalArray(intArrTwoDimensionalArray);
int[] xY = SerchTwoDimensionalArray(intArrTwoDimensionalArray);
Print(xY);
PrintTwoDimensionalArray(UpdateTwoDimensionalArray(intArrTwoDimensionalArray, xY[0], xY[1]));

