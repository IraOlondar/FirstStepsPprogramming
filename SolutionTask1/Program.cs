/**
* Проверка на равенство второго числа квадрату первого
*/
Console.WriteLine("введите первое число:");
string? firstNumber = Console.ReadLine();
Console.WriteLine("введите второе число:");
string? secondNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null) {
    int firstOutNumber = int.Parse(firstNumber);
    int secondOutNumber = int.Parse(secondNumber);
    int firstOutQuatroNumber = (int) Math.Pow(firstOutNumber,2);
    
    if (firstOutQuatroNumber == secondOutNumber) {
        Console.WriteLine("да");
    } else {
        Console.WriteLine("нет");
    }
}
