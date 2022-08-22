/**
* Задайте значения N и M. Напишите программу, 
* которая найдёт сумму натуральных элементов в промежутке от N до M.
*
*/

int Read (string m) {
    Console.Write(m);
    string? input = Console.ReadLine() ?? "";
    return int.Parse(input);
}

int RecurseSumm (int v, int p) {
    if (p == 1) return v;
    return v++ + RecurseSumm(v, --p);
}

int N = Read("Введите N: ");
int M = Read("Введите M: ");

Console.WriteLine(RecurseSumm(N, M));
