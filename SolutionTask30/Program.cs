System.Random numberSintezator = new Random();

void variantNaive (int n) {
    int i = 0;
    
    Console.Write("[");
    while (i < n - 1) {
        Console.Write(numberSintezator.Next(0, 2) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0, 2));
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    int inputNumber = int.Parse(input);

    variantNaive(inputNumber); 
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}
