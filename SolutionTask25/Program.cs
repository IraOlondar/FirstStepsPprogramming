/**
* Калькулятор (+,-,*,/,^)
*
*/

//Подключение методов работы с регулярными выражениями
using System.Text.RegularExpressions;

//Bзменение языка и региональных параметров для правильной работы double.Parse
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

//Папрсим строку ввода вида (например 10.3+5) и выводим список вида [число, число, знак действия]
string[] riad(string n) {
    string[] result = new string[3] {"0", "0", "-E"}; 

    // Шаблон регулярного выражения
    string pattern = @"([-]?[0-9]+[.,]?[0-9]*)([-+*\/\^])([-]?[0-9]+[.,]?[0-9]*)";
 
    //Поиск всех совпадения через регулярные выражения
    MatchCollection matches = Regex.Matches(n.Replace(" ", ""), pattern);
 
    try {
        foreach (Match match in matches) {
            result[0] = match.Groups[1].Value;
            result[1] = match.Groups[3].Value;
            result[2] = match.Groups[2].Value;
        }

    } catch (InvalidOperationException) {}
    
    return result;
}

//Калькуляция значений а и b
string calc(double a, double b, string action) {
    double result = 0;

    if (b != 0 || action != "/") {
        switch (action) {
            case "+": 
                result = a + b;
                break;
            case "-": 
                result = a - b;
                break;
            case "*": 
                result = a * b;
                break;
            case "/": 
                result = a / b;
                break;
            case "^": 
                result = Math.Pow(a, b);
                break;
        }
        return Math.Round(result, 2).ToString();
    } else {
        return "-E";
    }
}

//Вывод результата на экран
void print (string res) { 
    Console.WriteLine(res);
}

Console.Write("Введите пример: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    //Получаем список вида [число, число, знак действия]
    string[] inputString = riad(input);
    double a = double.Parse(inputString[0].Replace(",", "."));
    double b = double.Parse(inputString[1].Replace(",", "."));

    if (inputString[2] != "-E") {
        //Получаем результат решения
        string recCalc = calc(a, b, inputString[2]);
        
        //Выводим результат вычисления
        print($"{a} {inputString[2]} {b} = {recCalc}");
    } else {
        //Выводим ошибку
        print($"{input} = -E");
    }
    
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}