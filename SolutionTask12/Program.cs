/**
* Проверка на кратность второго числа первому
*
*/
Console.WriteLine("введите первое число:");
string firstNumber = Console.ReadLine() ?? "";
Console.WriteLine("введите второе число:");
string secondNumber = Console.ReadLine() ?? "";

void funck (int a, int b) {
    string text = "";
    if (a != 0 && b != 0) {
        int c = b % a;     
        if (c == 0) {
            text = "да, второе число кратно первому"; 
        } else {
            text = "нет, второе число не кратно первому, остаток: " + c; 
        }
        Console.WriteLine(text);
    } else {
        text = "ошибка ввода(a: " + a + ", b: " + b + ")";
        Console.WriteLine(text);
    }
}

if (
        firstNumber != "" 
        && firstNumber != null 
        && secondNumber != "" 
        && secondNumber != null
    ) {
    int firstOutNumber = int.Parse(firstNumber);
    int secondOutNumber = int.Parse(secondNumber);
    funck(firstOutNumber, secondOutNumber);

}