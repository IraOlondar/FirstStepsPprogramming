/**
* Задайте значения M и N. Напишите программу, 
* которая выведет все натуральные числа в промежутке от M до N.
*
*/

int Read (string m) {
    Console.Write(m);
    string? input = Console.ReadLine() ?? "";
    return int.Parse(input);
}

void RecursePrint (int n, int m) {
    if (n <= m) {
        Console.Write(n + " ");
        RecursePrint(++n, m);
    }
}


int N = Read("Введите N: ");
int M = Read("Введите M: ");

RecursePrint(N, M);

