Console.WriteLine("введите первое число:");
string? a = Console.ReadLine() ?? "";
Console.WriteLine("введите второе число:");

string? b = Console.ReadLine() ?? "";

void fun (int firstNumber, int secondNumber) {
    int firstOutQuatroNumber = (int) Math.Pow(firstNumber,2);
    int secondOutQuatroNumber = (int) Math.Pow(secondNumber,2);
    
    if (secondNumber > firstNumber) {
        if (firstOutQuatroNumber == secondNumber) {
            Console.WriteLine("второе число равно квадрату первого");
        } else {
            Console.WriteLine("второе число не равно квадрату первого");
        }
    } else {
        if (secondOutQuatroNumber == firstNumber) {
            Console.WriteLine("первое число равно квадрату второго");
        } else {
            Console.WriteLine("первое число не равно квадрату второг");
        }
    }
}

if (a != "" && b != "") {
    int outA = int.Parse(a);
    int outB = int.Parse(b);
    fun(outA, outB);
}