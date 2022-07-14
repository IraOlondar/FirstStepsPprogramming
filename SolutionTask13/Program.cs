/**
* Вывод n (3) - й цифры введенного числа
*
*/
//Метод №1
int n = 3; //порядковый номер нужной нам цифры для вывода
Console.WriteLine("введите число:");

string text = "";
try {
    int? ss = Convert.ToInt32(Char.GetNumericValue (Console.ReadLine() ?? "", (n-1)));
    if (ss != -1) {
        text = "цифра с порядковым номером " + n + " равна: " + ss;
    }
} catch (ArgumentOutOfRangeException) {
    text = "цифры с порядковым номером " + n + " в веденном числе нет!";
}

// Console.WriteLine(text);

//Метод №2
// int n = 3; //порядковый номер нужной нам цифры для вывода
// Console.WriteLine("введите число:");
// int[]? arr = Console.ReadLine()?.Select(x => x - '0').ToArray();
// string text = "";
// if (arr?.Length >= n) {
//     text = "цифра с порядковым номером " + n + " равна: " + arr[n-1];
// } else {
//     text = "цифры с порядковым номером " + n + " в веденном числе нет!";
// }
// Console.WriteLine(text);

//Метод №3
// int n = 3; //порядковый номер нужной нам цифры для вывода
// Console.WriteLine("введите число:");
// string text = "";
// int[]? arr = Console.ReadLine()?.Select(x => Convert.ToInt32(Char.GetNumericValue(x))).ToArray();
// if (arr?.Length >= n) {
//     text = "цифра с порядковым номером " + n + " равна: " + arr[n-1];
// } else {
//     text = "цифры с порядковым номером " + n + " в веденном числе нет!";
// }
// Console.WriteLine(text);

//Метод №4
// int n = 3; //порядковый номер нужной нам цифры для вывода
// Console.WriteLine("введите число:");
// string? str = Console.ReadLine() ?? "";
// string text = "";
// if (str.Length >= n) {
//     text = "цифра с порядковым номером " + n + " равна: " + str.Substring (n, 1);
// } else {
//     text = "цифры с порядковым номером " + n + " в веденном числе нет!";
// }
// Console.WriteLine(text);