/**
* Создание двумерного массива. Нахождение элементов, у которых оба индекса чётные, и замена этих элементов на их квадраты.
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

//Модификация массива
int[,] UpdateTwoDimensionalArray (int[,] arr) {
    int i = 0, j = 0;
    int[,] newArray = new int[arr.GetLength(0), arr.GetLength(1)];
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            newArray[i,j] = arr[i,j];
            
            if (i % 2 == 0 && j % 2 == 0) 
                newArray[i,j] *= arr[i,j];

            j++;
        }
        i++;
    }

    return newArray;
}

//Выводим на печать массив
void PrintTwoDimensionalArray (int[,] arr) {
    int i = 0, j = 0;
    Console.WriteLine();
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
PrintTwoDimensionalArray(intArrTwoDimensionalArray);
PrintTwoDimensionalArray(UpdateTwoDimensionalArray(intArrTwoDimensionalArray));