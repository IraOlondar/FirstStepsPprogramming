/**
* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
* Даны два неотрицательных числа N и M.
*
*/

int Read (string m) {
    Console.Write(m);
    string? input = Console.ReadLine() ?? "";
    return int.Parse(input);
}

int Akkerman(int n, int m) {
    if (n == 0)
        return m + 1;
    else if((n > 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else if((n > 0) && (m > 0))
        return Akkerman(n - 1, Akkerman(n, m - 1));
    return m + 1;
}


int N = Read("Введите N: ");
int M = Read("Введите M: ");

if (N > 0 && M > 0)
    Console.WriteLine(Akkerman(N, M));
else
    Console.WriteLine("Функцию Аккермана вычеслить невозможно!");
