/**
* Создание двумерного массива. 
* Поменять местами первую и последнюю строку
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

//Меняем строки на столбци
void UpdateTwoDimensionalArray (int[,] arr) {
    int i = 0;
    int j = 0;
    int temp = 0;
    while(i < arr.GetLength(0)) {
        while(j < arr.GetLength(1)) {
            temp = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = temp;
            j++;
        }
        i++;
    }
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
int[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(5, 5, 0, 100);
PrintTwoDimensionalArray(intArrTwoDimensionalArray);
if (intArrTwoDimensionalArray.GetLength(0) == intArrTwoDimensionalArray.GetLength(1)) {
    UpdateTwoDimensionalArray(intArrTwoDimensionalArray);
    PrintTwoDimensionalArray(intArrTwoDimensionalArray);
} else {
    Console.WriteLine("Массив не квадратный! Развернут нельзя.");
}   
