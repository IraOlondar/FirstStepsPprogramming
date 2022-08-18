/**
* Создание двумерного массива. 
* Нахождение строки с наименьшей суммой элементов.
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

//Нахождение строки с наименьшей суммой элементов.
int SearchMinStringTwoDimensionalArray (int[,] arr) {
    int i = 0;
    int j = 0;
    int xMin = -1;
    int min = 0;
    int summ = 0;

    while(i < arr.GetLength(0)) {
        j = 0;
        summ = 0;
        while(j < arr.GetLength(1)) {
            summ =+ arr[i,j];
            j++;
        }
        if (min > summ || xMin == -1) {
            min = summ;
            xMin = i;
        }
        i++;
    }
    return xMin;
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
Console.WriteLine(" Индекс искомой строки равен: " + SearchMinStringTwoDimensionalArray(intArrTwoDimensionalArray));

