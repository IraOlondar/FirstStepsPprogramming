Console.WriteLine("введите первое число:");
string? a = Console.ReadLine() ?? "";
Console.WriteLine("введите второе число:");

string? b = Console.ReadLine() ?? "";

void fun (int firstNumber, int secondNumber) {
    int firstOutQuatroNumber = (int) Math.Pow(firstNumber,2);
    int secondOutQuatroNumber = (int) Math.Pow(secondNumber,2);
    string yes = "";
    int index = 0;
    
    if (firstOutQuatroNumber != secondNumber && secondOutQuatroNumber != firstNumber) yes = "не ";
    if ( secondNumber > firstNumber) index = 1;        

    string[] text = {
        "первое число " + yes + "равно квадрату второго",
        "второе число " + yes + "равно квадрату первого"
    };
    Console.WriteLine(text[index]);
}

if (a != "" && b != "") {
    int outA = int.Parse(a);
    int outB = int.Parse(b);
    fun(outA, outB);
}