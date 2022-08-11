/**
* Создание двумерного массива. Нахождение суммы элементов, находящихся на главной диагонали
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

//Сумма элементов диагонали
int CalcDiagTwoDimensionalArray (int[,] arr) {
    int i = 0;
    int summ = 0;
    while(i < arr.GetLength(0)) {
            summ += arr[i,i];
        i++;
    }

    return summ;
}


//Выводим на печать массив с подсветкой цвета
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
Console.WriteLine(CalcDiagTwoDimensionalArray(intArrTwoDimensionalArray));
