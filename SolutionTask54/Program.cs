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

//Построчная сортировка массива
int[,] UpdateTwoDimensionalArray (int[,] inputArr) {
    int i = 0;
    int j = 0;
    int k = 0;
    int x;
    int temp;

    while(i < inputArr.GetLength(0)) {
        j = 0;
        while(j < inputArr.GetLength(1)) {
            x = inputArr[i,j];
            k = j;
            while (k > 0 && inputArr[i,k - 1] > x) {
                temp = inputArr[i,k];
                inputArr[i,k] = inputArr[i,k - 1];
                inputArr[i,k - 1] = temp;
                k -= 1;
            }
            inputArr[i,k] = x;
            j++;
        }
        i++;
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

