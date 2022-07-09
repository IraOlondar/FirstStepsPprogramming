/**
* Вывод всех целых чисел в промежутке от -N до N
*
*/
Console.WriteLine("веедите число:");
string? number = Console.ReadLine();

if (number != null) {
    int outNumber = int.Parse(number);  
    int startNomber = outNumber * -1;
    string text = "";
    while (startNomber < outNumber) {
        text += startNomber + ", ";
        startNomber++;
    }

    text += outNumber;
    Console.WriteLine(text);
}