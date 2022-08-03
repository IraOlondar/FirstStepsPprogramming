/**
* Определение количество цифр в числе
*
*/

int variantChar (string num) {
    return num.ToCharArray().Length;
}

int variantInt (long num) {
    int numberLength = 0;
    long digits = 1;
   
    while (digits < num) {
        digits = digits * 10;
        numberLength++;
    }

    return numberLength;
}

int variantLog (long num) {
     return (int) Math.Log10(num) + 1;
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    long inputNumber = long.Parse(input);
    long result = 0;
    DateTime timePoint;

    timePoint = DateTime.Now;
    result = variantChar(input);
    Console.WriteLine($"В числе {inputNumber} {result} цифр");
    Console.WriteLine(DateTime.Now - timePoint);

    timePoint = DateTime.Now;
    result = variantInt(inputNumber);
    Console.WriteLine($"В числе {inputNumber} {result} цифр");
    Console.WriteLine(DateTime.Now - timePoint);

    timePoint = DateTime.Now;
    result = variantLog(inputNumber);
    Console.WriteLine($"В числе {inputNumber} {result} цифр");
    Console.WriteLine(DateTime.Now - timePoint);
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}