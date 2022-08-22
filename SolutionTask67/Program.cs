/**
* Задайте значения M и N. Напишите программу, 
* которая будет принимать на вход число и возвращать сумму его цифр.
*
*/

int Read (string m) {
    Console.Write(m);
    string? input = Console.ReadLine() ?? "";
    return int.Parse(input);
}

int Summ (int n) {
    if (n == 0) return 0;
    return n % 10 + Summ(n / 10);
}

int N = Read("Введите число: ");

Console.WriteLine(Summ(N));
