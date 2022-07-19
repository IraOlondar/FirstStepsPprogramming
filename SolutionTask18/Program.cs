/**
* Вывод диапазона возможных координат по номеру четверти
*
*/
void printAnswer(int number) {
    if(number == 1) Console.WriteLine("допустимый диапазон: x>0, y>0");
    if(number == 2) Console.WriteLine("допустимый диапазон: x<0, y>0");
    if(number == 3) Console.WriteLine("допустимый диапазон: x<0, y<0");
    if(number == 4) Console.WriteLine("допустимый диапазон: x>0, y<0");
}

Console.Write("введите номер четверти (1-4): ");
string? inputInline = Console.ReadLine() ?? "";

if (inputInline != "") {
    
    int inputNumber = int.Parse(inputInline);

    if (0<inputNumber && inputNumber<4)
        printAnswer(inputNumber);
    else
        Console.Write("Ведено недопустимое значение");
} else {
    Console.Write("Ошибка ввода, пустое значение");
}