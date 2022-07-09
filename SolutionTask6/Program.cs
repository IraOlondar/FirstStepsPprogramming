/**
* Проверка на четность
*
*/
Console.WriteLine("веедите число:");
string? number = Console.ReadLine();

if (number != null) {
    int outNumber = int.Parse(number);  
     if (outNumber % 2 > 0) {
        Console.WriteLine("не четное");
    } else {
        Console.WriteLine("четное");
    }
}