/**
* Проверка на равенство второго числа квадрату первого
*
*/
Console.WriteLine("введите первое число:");
string? firstNumber = Console.ReadLine();
Console.WriteLine("введите второе число:");
string? secondNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null) {
    int firstOutNumber = int.Parse(firstNumber);
    int secondOutNumber = int.Parse(secondNumber);
    string max = "max: ";
    string min = "min: ";
    if (firstOutNumber > secondOutNumber) {
        max += firstOutNumber;
        min += secondOutNumber;
    } else {
        max += firstOutNumber;
        min += secondOutNumber;
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
}
