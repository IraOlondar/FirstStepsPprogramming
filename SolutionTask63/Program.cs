int Read () {
    Console.Write("Ведите число: ");
    string? input = Console.ReadLine() ?? "";
    if (input != "") {
        return int.Parse(input);
    } else {
        Console.WriteLine("Пустая строка!");
    }
    return 0;
}

void RecursePrint (int n) {
    if (n >= 1) {
        Console.Write(n + " ");
        RecursePrint(--n);
    }
}


int inputNumber = Read();

RecursePrint(inputNumber);

