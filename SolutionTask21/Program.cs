/**
* Вывод расстояния меджу двумя точками в 3D пространстве
*
*/

//Подключение методов работы с регулярными выражениями
using System.Text.RegularExpressions;
 
//Метод извлечения из строки координат точек
int[,] regexToArray (string input) {
    // Шаблон регулярного выражения поиск 6-х переменных
    string pattern = @"A\(([-]?[0-9]+),([-]?[0-9]+),([-]?[0-9]+)\);B\(([-]?[0-9]+),([-]?[0-9]+),([-]?[0-9]+)\)";
 
    //Поиск всех совпадения через регулярные выражения
    MatchCollection matches = Regex.Matches(input, pattern);
 
    //Созданние массива координат
    int[,] arrCoord = new int[2,3];
    //Вывод координат из 6-и групп Matches
    try {
        foreach (Match match in matches) {
            arrCoord[0,0] = int.Parse(match.Groups[1].Value);
            arrCoord[0,1] = int.Parse(match.Groups[2].Value);
            arrCoord[0,2] = int.Parse(match.Groups[3].Value);
            arrCoord[1,0] = int.Parse(match.Groups[4].Value);
            arrCoord[1,1] = int.Parse(match.Groups[5].Value);
            arrCoord[1,2] = int.Parse(match.Groups[6].Value);
        }

    } catch (InvalidOperationException e) {
        Console.WriteLine($"Ошибка ввода: {e}");
    }
    
    return arrCoord;
}
 
//Метод вывода расстояния между точками
void distansePrint (int[,] arr) {
 
    int coordAX = arr[0,0];
    int coordAY = arr[0,1];
    int coordAZ = arr[0,2];
    int coordBX = arr[1,0];
    int coordBY = arr[1,1];
    int coordBZ = arr[1,2];
    
    //Находжение расстояния меду точками с помощью теоремы Пифагора
    double distanceAB = Math.Round(Math.Sqrt(
            Math.Pow((coordAX - coordBX), 2)
            + Math.Pow((coordAY - coordBY), 2)
            + Math.Pow((coordAZ - coordBZ), 2)
        ), 2);
 
    //Вывод результата
    Console.WriteLine("Расстояние между точкой"
        + $"A({arr[0,0]},{arr[0,1]},{arr[0,2]})"
        + $"B({arr[1,0]},{arr[1,1]},{arr[1,2]}): {distanceAB}"
    );
}
 
Console.Write("Введите координаты в формате \"A(x,y,z);B(x,y,z)\":");
string input = Console.ReadLine() ?? "";
//string input = "A(1,3,6);B(4,-3,2)";
 
if (input != "") {
    int[,] arrayOut = regexToArray(input);
    distansePrint (arrayOut);

} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}