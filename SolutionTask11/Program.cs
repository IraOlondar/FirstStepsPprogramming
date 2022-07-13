/**
* Удалить вторую цифру из случайного трехзначного числа
* 
*/

/*Находим случайное число от 100 до 999*/
int number = new Random().Next(100,999);

Console.WriteLine(number);

/*Преобразуем число в строку*/
string? text = number.ToString();

/*Нахождение подстроки с индексом 0, дляной 1*/
string a = text.Substring(0, 1);

/*Нахождение подстроки с индексом 2, дляной 1*/
string b = text.Substring(2, 1);
string c = a + b;

Console.WriteLine(c);