/**
* Наибольшая цифра сдучайного числа между 10 и 99
* 
*/
int number = new Random().Next(10,99);
Console.WriteLine(number);

string? text = number.ToString();

int a = int.Parse(text.Substring(0, 1));
int b = int.Parse(text.Substring(1, 1));
int max = 0;
 if (a > b) {
    max = a;
 } else {
    max = b;
 }

 Console.WriteLine(max);