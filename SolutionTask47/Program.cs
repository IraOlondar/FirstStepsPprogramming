/**
*   Создание двумерного массива, заполененного случайными вещественными числами.
*   При выводе матрицы показывать каждую цифру разного цвета!
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
double[,] GenTwoDimensionalArray (int m, int n) {
    int i = 0, j = 0;
    double[,] array = new double[m, n];

    while (i < m) {
        j = 0;
        while (j < n) {
            array[i,j] = numberSintezator.NextDouble() * 40 - 20;
            j++;
        }
        i++;
    }

    return array;
}

//Вывод на печать разноцветного числа
void PrintColorNumber (double number) {
    number.ToString().ToList().ForEach(x => {
        Console.ForegroundColor = (ConsoleColor)(numberSintezator).Next(1,16); //пропускаем черный
        Console.Write(x); 
    });
    Console.ResetColor();
}

//Выводим на печать массив
void PrintTwoDimensionalArray (double[,] arr) {
    int i = 0, j = 0;
    double val;
    Console.WriteLine();
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            val = Math.Round(arr[i,j], 4);
            Console.Write(new string(' ', 8 - val.ToString().Length));
            PrintColorNumber(val);
            Console.Write(" "); 
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}


//GenTwoDimensionalArray(M, N);
double[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(10, 10);
PrintTwoDimensionalArray(intArrTwoDimensionalArray);
