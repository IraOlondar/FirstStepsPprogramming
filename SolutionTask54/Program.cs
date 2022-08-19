/**
* Создание двумерного массива. 
* Построчная сортировка массива
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

//Сортировка массива
int[]  Sort(int[] arr) {
    int i, j, tmp, x;

    for (i = 1; i < arr.Length; i++) {
        x = arr[i];
        j = i;
        while (j > 0 && arr[j - 1] > x) {
            tmp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = tmp;
            j -= 1;
        }
        arr[j] = x;
    }

    return arr;
}

//Построчная сортировка массива
int[,] UpdateTwoDimensionalArray (int[,] inputArr) {
    int[] array = new int[inputArr.GetLength(1)];

    for(int i = 0; i < inputArr.GetLength(0); i++) {
        for(int j = 0; j < inputArr.GetLength(1); j++) {
            array[j] = inputArr[i,j];
        }

        array = Sort(array);

        for(int j = 0; j < inputArr.GetLength(1); j++) {
            inputArr[i,j] = array[j];
        }
    }
    return inputArr;
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
int[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(10, 10, 0, 100);

PrintTwoDimensionalArray(intArrTwoDimensionalArray);
PrintTwoDimensionalArray(UpdateTwoDimensionalArray(intArrTwoDimensionalArray));

