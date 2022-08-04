/**
* Вывод массива по заданной длинне и границам диапазона хзначений
*/

System.Random numberSintezator = new Random();

void genArray (int n, int min, int max) {
    int i = 0;
    
    Console.Write("[");
    while (i++ < n) {
        Console.Write(numberSintezator.Next(min, max + 1) + (i == n ? "" : ","));
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
string input = Console.ReadLine() ?? "";

Console.Write("Введите нижнюю границу диапазона значений: ");
string minValue = Console.ReadLine() ?? "";

Console.Write("Введите верхнюю границу диапазона значений: ");
string maxValue = Console.ReadLine() ?? "";

if (input != "" && minValue != "" && maxValue != "") {
    int inputNumber = int.Parse(input);
    int minValueNumber = int.Parse(minValue);
    int maxValueNumber = int.Parse(maxValue);

    genArray(inputNumber, minValueNumber, maxValueNumber); 
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}
