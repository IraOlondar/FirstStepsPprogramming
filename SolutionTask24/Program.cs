/**
* Сумма чисел от 1 до A
*
*/

void variantSimple (int num) {
    int i = 1;
    int sum = 0;

    while (i <= num) {
        sum += i++;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
}

void variantGauss (int num) {
    int sum = 0;

    //Находим сумму с помощью арифметической прогресии
    sum  = num * (1 + num) / 2 ;
    
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    int t;
    int inputNumber = int.Parse(input);

    t = Environment.TickCount;
    variantSimple(inputNumber);
    Console.WriteLine("Simpli Line: {0} ms", Environment.TickCount - t);
    
    variantGauss(inputNumber);
    Console.WriteLine("Simpli Line: {0} ms", Environment.TickCount - t);
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}
