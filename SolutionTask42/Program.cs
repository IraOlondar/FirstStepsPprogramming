/**
* Преобразование десятичного числа в двоичное
*
*/

//Читаем консоль
int ReadSieds () {
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine() ?? "");
}

//Преобразуем десятичное число в двоичное
string ConvertIntToBin (int n) {
    return Convert.ToString(n, 2);
}

//Выводим результат
void Print (string num) {
    Console.WriteLine(num);
}

Print(ConvertIntToBin(ReadSieds()));