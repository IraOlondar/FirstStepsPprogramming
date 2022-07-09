/**
* Вывод названия недели по заданому номеру
*
*/
string[] week = new string[7];

week[0] ="Понедельник";
week[1] ="Вторник";
week[2] ="Среда";
week[3] ="Четверг";
week[4] ="Пятница";
week[5] ="Суббота";
week[6] ="Воскреснье";

Console.WriteLine("веедите порядковый номер дня недели:");
string? deyWeeekNumber = Console.ReadLine();

if (deyWeeekNumber != null) {
    int outDeyWeeekNumber = int.Parse(deyWeeekNumber);  
    string textOutDeyWeeek = week[outDeyWeeekNumber - 1];
    Console.WriteLine(textOutDeyWeeek);
}
