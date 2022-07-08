string? inputInline = Console.ReadLine();

if (inputInline != null) {
    int inputNumber = int.Parse(inputInline);
    //int outNumber = inputNumber*inputNumber;
    int outNumber = (int) Math.Pow(inputNumber,2);
    Console.WriteLine(outNumber);
}