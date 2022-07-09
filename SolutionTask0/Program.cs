/**
* Вычисление квадрата введенного числа
*
*//*  */
Console.WriteLine("введите число");
string? inputInline = Console.ReadLine();

if (inputInline != null) {
    int inputNumber = int.Parse(inputInline);
    //int outNumber = inputNumber*inputNumber;
    int outNumber = (int) Math.Pow(inputNumber,2);
    string text = "квадрат числа " + inputNumber + " будет: " + outNumber;
    Console.WriteLine(text);
}