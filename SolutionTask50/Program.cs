/**
* Создание двумерного массива. Заполнение массива числами Фиббоначи и выделение цветом найденного по индексам элемента
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
long[,] GenTwoDimensionalArray (int m, int n, int min, int max) {
    int i = 0, j = 0;
    long[,] array = new long[m, n];

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

//Вывод на печать разноцветного числа
void PrintColorString (string str) {
    str.ToList().ForEach(x => {
        Console.ForegroundColor = (ConsoleColor)(numberSintezator).Next(1,16); //пропускаем черный
        Console.Write(x); 
    });
    Console.ResetColor();
}

//Модификация массива
long[,] UpdateTwoDimensionalArray (long[,] arr) {
    int i = 0, j = 0, x = 0;
    long[,] newArray = new long[arr.GetLength(0), arr.GetLength(1)];
    long f_1 = 0;
    long f_2 = 1;
    long fn;

    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            if (x == 0) 
                newArray[i,j] = 0;
            else if (x == 1)
                newArray[i,j] = 1;
            else {
                fn = f_1 + f_2;
                newArray[i,j] = fn;
                f_1 = f_2;
                f_2 = fn;
            }
            x++;
            j++;
        }
        i++;
    }

    return newArray;
}

//Выводим на печать массив
void PrintTwoDimensionalArray (long[,] arr) {
    int i = 0, j = 0;
    long val;
    Console.WriteLine();
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            val = arr[i,j];
            Console.Write(new string(' ', arr[arr.GetLength(0) - 1,arr.GetLength(1) - 1].ToString().Length + 1 - val.ToString().Length));
            Console.Write(arr[i,j]);
            Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}

//Раскрашиваем елемент если, есть по индексам
void SearchColorTwoDimensionalArray (long[,] arr, string a, string b) {
    int intA = int.Parse(a);
    int intB = int.Parse(b);
    if (intA < arr.GetLength(0) && intB < arr.GetLength(1)) {
        int i = 0, j = 0;
        long val;
        Console.WriteLine();
        while(i < arr.GetLength(0)) {
            j = 0;
            while(j < arr.GetLength(1)) {
                val = arr[i,j];
                Console.Write(new string(' ', arr[arr.GetLength(0) - 1,arr.GetLength(1) - 1].ToString().Length + 1 - val.ToString().Length));
                if (i == intA && j == intB) {
                    PrintColorString(arr[i,j].ToString());
                } else {
                    Console.Write(arr[i,j]);
                }
                Console.Write(" ");
                j++;
            }
            Console.WriteLine();
            i++;
        }
        Console.WriteLine();
    } else {
        PrintColorString("Индексы находятся за пределами диапазона");
    }
}

int maxIndexA = 10;
int maxIndexB = 5;

//GenTwoDimensionalArray(M, N, ОТ, ДО);
long[,] intArrTwoDimensionalArray = GenTwoDimensionalArray(maxIndexA, maxIndexB, 0, 100);
//PrintTwoDimensionalArray(intArrTwoDimensionalArray);

long[,] newArrTwoDimensionalArray = UpdateTwoDimensionalArray(intArrTwoDimensionalArray);
PrintTwoDimensionalArray(newArrTwoDimensionalArray);

Console.Write($"Введите индек строки от 0 до {maxIndexA - 1}: ");
string a = Console.ReadLine() ?? "";
Console.Write($"Введите индекс стольбца от 0 до {maxIndexB - 1}: ");
string b = Console.ReadLine() ?? "";
 
if (a != "" && b != "") {
    SearchColorTwoDimensionalArray(newArrTwoDimensionalArray, a, b);
} else {
    Console.Write("Ошибка ввода, пустое значение");
}