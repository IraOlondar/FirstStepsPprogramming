/**
* Вывод всех целых чисел в промежутке от 1 до N
*
*/
Console.WriteLine("веедите число:");
string? number = Console.ReadLine();

if (number != null) {
    int outNumber = int.Parse(number);  
    string text = "";
    int startNomber;
    int stopNomber;
    if (outNumber > 0) {
        startNomber = 2;
        stopNomber = outNumber - 1;
    } else {
        startNomber = outNumber + 1;
        stopNomber = 0;
    }
    while (startNomber < stopNomber) {
        text += startNomber + ", ";
        startNomber++;
    }
    text += stopNomber;
    Console.WriteLine(text);
}