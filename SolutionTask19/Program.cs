/**
* Проверка на принадлежность к палиндромам введенного числа
*
*/

//Разворот числа
int revetsInt (int num) {
    int size = 1;
    int reverse = 0;

    while (size * 10 <= num) {
        size = size * 10;
    }

    while (1 <= num) {
        reverse += (num % 10) * size;
        num = num / 10;
        size = size / 10;
    }
    return reverse;
}

//Определение разряда числа
int intSize (int num) {
    int size = 1;
    while (size * 10 <= num) {
        size = size * 10;
    }
    return size ;
}

//Ппределение длины числа
int intLength (int num) {
    int size = 1;
    int count = 1;
    while (size * 10 <= num) {
        size = size * 10;
        count++;
    }
    
    return count;
}

//Порядковый номер центральной цифры
int halfInput (int num) {
    int size = 1;
    int count = 2;
    while (size * 10 <= num) {
        size = size * 10;
        count++;
    }
    
    return count / 2;
}

//Удаление цинтральной цифры числа
int inputOnelHalf (int input) {
    int size = intSize(input);
    int countHalf = halfInput(input);
    int bRemains = 1;
    int i = 1;
    int result = 0;
    while (1 <= input) {
        if (countHalf != i) {
            result += (input % 10) * bRemains;
            bRemains = bRemains * 10;
        }
        input = input / 10;
        size = size / 10;
        i++;
    }

    return result;
}

//Создание справочника палиндромов того же разряда что и введенное число, но без центральной цифры
Dictionary<int, int> addDicrionary (int straight) {
    Dictionary<int, int> dictPolindrom = new Dictionary<int, int>();
    
    int half = halfInput(straight);
    int intLen = intLength(straight);
    int result = 0;

    if (intLen % 2 == 0) half++;

    for (int j = (int) Math.Pow(10, half - 2); j < (int) Math.Pow(10, half - 1); j++) {
        
        //Правая часть палиндрома
        int rev = revetsInt(j);

        //Добавляем к левой сачти правую
        result = j * (int) Math.Pow(10, half - 1)+ rev; 

        //Добавляем палиндром в справочник
        dictPolindrom.Add(j, result);
    }

    return dictPolindrom;
}
Console.WriteLine("Поверь является ли число палиндромом!");
Console.Write("Введите любое число oт 0 до 2147483647: ");
string input = Console.ReadLine() ?? "";
//string input = "123454321";

try {
    
    if (input != "") {
        int straight = int.Parse(input);
        int reverseOneCenter = 0;
        
        //если введенное число четное то оставляем его иначе удаляем центральную цифру
        if (input.Length % 2 != 0) {
            reverseOneCenter = inputOnelHalf(straight);
        } else {
            reverseOneCenter = straight;
        }

        //Генерим словарь из полиндромов размерности введенного числа без центральной цифры
        Dictionary<int, int> dictPolindrom = addDicrionary(straight);

        //Проверка на присутствие введенного числа в справочнике
        if (dictPolindrom.ContainsValue(reverseOneCenter))
            Console.WriteLine("Это палиндром");
        else
            Console.WriteLine("Это не палиндром");
    } else {
        Console.WriteLine($"Input error: empty request");
    }
    
} catch (OverflowException e) {
    Console.WriteLine($"Input error: {e.Message}");
}