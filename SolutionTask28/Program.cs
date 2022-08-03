/**
* Произведение чисел от 1 до A
*
*/


int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}

void variantSimple (int num) {
    int i = 1;
    int sum = 1;

    while (i <= num) {
        sum *= i++;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} равна {sum}");
}

void variantFaсt (int num) {
    int sum = 1;

    //Находим произведение с помощью факториала
    sum  = Factorial(num);
    
    Console.WriteLine($"Произведение чисел от 1 до {num} равна {sum}");
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    int inputNumber = int.Parse(input);
    DateTime timePoint;

    timePoint = DateTime.Now;
    variantSimple(inputNumber);
    Console.WriteLine(DateTime.Now - timePoint);
    
    timePoint = DateTime.Now;
    variantFaсt(inputNumber);
    Console.WriteLine(DateTime.Now - timePoint);
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}