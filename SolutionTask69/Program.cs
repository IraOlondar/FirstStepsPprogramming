/**
* Напишите программу, которая на вход принимает два числа N и M,
* и возводит число N в целую степень M с помощью рекурсии.
*
*/

int Read (string m) {
    Console.Write(m);
    string? input = Console.ReadLine() ?? "";
    return int.Parse(input);

}

int SimplePow (int v, int p) {
    if (p == 0) return 1;
    return SimplePow(v, p - 1) * v;
}

double Pow(int v, int p) {
    if (p == 0) 
        return 1;
    if (p > 0) 
        return Pow(v, p - 1) * v;
    return 1.0 / Pow(v, -p);
}


int Pows(int v, int p) {
    if (p == 0) 
        return 1;
    if (p % 2 != 0) 
        return Pows(v * v, p / 2) * v;
    return Pows(v * v, p / 2);
}

int GolikovPow(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {
        return GolikovPow(a, b / 2) * GolikovPow(a, b / 2);
    }
    else
    {
        return GolikovPow(a, b / 2) * GolikovPow(a, (b / 2) + 1);
    }
}

int N = Read("Введите N: ");
int M = Read("Введите M: ");

Console.WriteLine();

DateTime timePoint = DateTime.Now;
int A = SimplePow(N, M);
Console.WriteLine($"Execution time {DateTime.Now - timePoint} - SimplePow");

timePoint = DateTime.Now;
double B = Math.Pow(N, M);
Console.WriteLine($"Execution time {DateTime.Now - timePoint} - C# Math.Pow");

timePoint = DateTime.Now;
double C = Pow(N, M);
Console.WriteLine($"Execution time {DateTime.Now - timePoint} - Pow");

timePoint = DateTime.Now;
double D = Pows(N, M);
Console.WriteLine($"Execution time {DateTime.Now - timePoint} - Pows");

timePoint = DateTime.Now;
int E = GolikovPow(N, M);
Console.WriteLine($"Execution time {DateTime.Now - timePoint} - GolikovPow");


Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(E);
