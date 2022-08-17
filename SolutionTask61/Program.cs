/**
* Вывести первые N строк треугольника Паскаля. 
* Сделать вывод в виде равнобедренного треугольника
*
*/

//Вычисляем факториал
float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string? s = Console.ReadLine();
n = Convert.ToInt32(s);

for (i = 0; i < n; i++)
{
    // создаём после каждой строки n-i отступов от левой стороны консоли, 
    // чем ниже строка, тем меньше отступ
    for (c = 0; c <= (n - i); c++)
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        // создаём пробелы между элементами треугольника
        Console.Write(" ");
        //формула вычисления элементов треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
    }

    Console.WriteLine();
    // после каждой строки с числами отступаем две пустые строчки
    Console.WriteLine();
}

