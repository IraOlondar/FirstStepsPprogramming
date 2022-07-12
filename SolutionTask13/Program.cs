/**
* Вывод n (3) - й цифры введенного числа
*
*/
//Метод №1
// int n = 3; //порядковый номер нужной нам цифры для вывода
// Console.WriteLine("введите число:");
// string? str = Console.ReadLine() ?? "";
// string text = "";
// int[] arr = str.Select(x => x - '0').ToArray();
// if (arr.Length >= n) {
//     text = "цифра с порядковым номером " + n + " равна: " + arr[n-1];
// } else {
//     text = "цифры с порядковым номером " + n + " в веденном числе нет!";
// }
// Console.WriteLine(text);

//Метод №2
int n = 3; //порядковый номер нужной нам цифры для вывода
Console.WriteLine("введите число:");
string? str = Console.ReadLine() ?? "";
string text = "";
if (str.Length >= n) {
    text = "цифра с порядковым номером " + n + " равна: " + str.Substring (n, 1);
} else {
    text = "цифры с порядковым номером " + n + " в веденном числе нет!";
}
Console.WriteLine(text);