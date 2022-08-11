/**
* Создание двумерного массива размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ=m+n.
*
*/

//Генерируем массив
int[,] GenTwoDimensionalArray (int m, int n, int min, int max) {
    int i = 0, j = 0;
    int[,] array = new int[m, n];

    while (i < m) {
        j = 0;
        while (j < n) {
            array[i,j] = i + j;
            j++;
        }
        i++;
    }

    return array;
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


//Выводим на печать массив с подсветкой цвета
void PrintTwoDimensionalArrayColor (int[,] arr) {
    int i = 0, j = 0;
    Console.WriteLine();
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            
            Console.ForegroundColor = (ConsoleColor)(new Random()).Next(1,16); //пропускаем черный
            Console.Write(arr[i,j] + (j != arr.GetLength(1) - 1 ? "\t" : ""));
            Console.ResetColor();
            
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
PrintTwoDimensionalArrayColor(intArrTwoDimensionalArray);
