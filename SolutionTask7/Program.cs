﻿/**
* Вывод последней цифры числа
*
*//*  */
Console.WriteLine("введите число");
string? inputInline = Console.ReadLine();

if (inputInline != null) {
    string lastNumber = inputInline.Substring(inputInline.Length-1);
    Console.WriteLine(lastNumber);
}