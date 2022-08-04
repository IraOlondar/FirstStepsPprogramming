/**
* Кто пойдет за пивом?
*/

System.Random numberSintezator = new Random();

//Генератор имени
void genName (string n) {
    //Разбираем имена на элементы списка
    string[] nams = n.Replace(" ", "").Split(',').ToArray();
    
    //Выводим случайное имя из списка
    Console.WriteLine($"За пивом пойдет {nams[numberSintezator.Next(0, nams.Length + 1)]}");
}

Console.WriteLine("Кто пойдет за пивом?");
Console.WriteLine("Введите через запятую всех учасников вечеринки: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    genName(input); 
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}
