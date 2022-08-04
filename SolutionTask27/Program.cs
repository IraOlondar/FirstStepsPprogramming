/**
* Определение суммы цифр числа
*
*/

//Нахождение суммы через пребор char массива
int variantChar (string num) {
    int summ = 0;
    char[] chars = num.ToCharArray();
    int i = 0;
    
    while (i < chars.Length){
        summ += Convert.ToInt32(Char.GetNumericValue(chars[i++]));
    }

    return summ;
}

//Нахождение суммы через черезь вешественные числа
int variantInt (string num) {
    long intNum = long.Parse(num);
    int summ = 0;
   
     while (1 <= intNum) {
        summ += (int) (intNum % 10);
        intNum = intNum / 10;
    }

    return summ;
}

//Нахождение суммы через черезь перебор подстрок длиной в одну символ
int variantString (string num) {
     int summ = 0;
     int i = 0;

     while (i < num.Length) {
        summ += int.Parse(num.Substring (i++, 1));
     }

     return summ;
}

//Нахождение суммы через Linq с использованием агрегатной функции 
int variantLinq (string num) {
    return num.Aggregate(0, (summ, x) => summ + Convert.ToInt32(Char.GetNumericValue(x)));
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";

if (input != "") {
    long result = 0;
    DateTime timePoint;

    timePoint = DateTime.Now;
    result = variantChar(input);
    Console.WriteLine($"Сумма цифр через метод \"variantChar\" равна: {result}");
    Console.WriteLine(DateTime.Now - timePoint);

    timePoint = DateTime.Now;
    result = variantInt(input);
    Console.WriteLine($"Сумма цифр через метод \"variantInt\" равна: {result}");
    Console.WriteLine(DateTime.Now - timePoint);

    timePoint = DateTime.Now;
    result = variantString(input);
    Console.WriteLine($"Сумма цифр через метод \"variantString\" равна: {result}");
    Console.WriteLine(DateTime.Now - timePoint);

    timePoint = DateTime.Now;
    result = variantLinq(input);
    Console.WriteLine($"Сумма цифр через метод \"variantLinq\" равна: {result}");
    Console.WriteLine(DateTime.Now - timePoint);
} else {
    Console.WriteLine("Ошибка ввода, пустое значение");
}