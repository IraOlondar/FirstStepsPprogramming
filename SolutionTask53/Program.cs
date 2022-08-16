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

//Меняем местами первую и последнюю строку двумерного массива
void UpdateTwoDimensionalArray (int[,] arr) {
    int j = 0;
    int temp = 0;
    while(j < arr.GetLength(0)) {
        temp = arr[0,j];
        arr[0,j] = arr[arr.GetLength(0) - 1,j];
        arr[arr.GetLength(0) - 1,j] = temp;
        j++;
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
int[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(10, 10, 0, 10);
PrintTwoDimensionalArray(intArrTwoDimensionalArray);
UpdateTwoDimensionalArray(intArrTwoDimensionalArray);
PrintTwoDimensionalArray(intArrTwoDimensionalArray);
