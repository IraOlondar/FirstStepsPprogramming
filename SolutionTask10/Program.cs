/**
* Вывод второй цифры трехзначного числа
*
*/
Console.WriteLine("введите трехзначное число:");
string? number = Console.ReadLine();

void print_two_int (int a) {
    if (a >= 100 && a <= 999) {
        /*Получаем остаток от деления на 100, отсекаем первую цифру
        Далее делим остаток на 10, получаем целую часть, то есть первую цифру*/
        int b = (a % 100)/10;
        Console.WriteLine(b); 
    } else { 
        Console.WriteLine("введено не трехзначное число");
    }   
}

if (number != "" && number != null) {
    int outNumber = int.Parse(number);
    print_two_int(outNumber);
}