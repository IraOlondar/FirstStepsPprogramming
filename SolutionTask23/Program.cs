/**
* Вывод таблицы чисел степени е = 3 чисел от 1 до N
*
*/

// //Метод набора чисел от 1 до N
// List<int> genericList (string input) {
//     int n = int.Parse(input);
//     int s = 1;
//     List<int> lineList = new List<int>();

//     //Заполенние листа числами
//     while (s <= n) {
//        lineList.Add(s);
//        s++;
//     }

//     return lineList;
// }

// //Метод подготовки набора чисел степени е = 3 и вывод на печать таблицы
// void linePrint (List<int> outList, string num, string exp) {
//     int n = int.Parse(num);
//     int expNum = int.Parse(exp);
    
//     //Создание листа чисел степени е = 3
//     List<int> outListN = addLisdtСube (outList, expNum);
    
//     Console.WriteLine($"Таблица чисел стени {expNum} от 1 до {n}:");

//     //Определяем длинну самого большого числа
//     int coutWhitespace = (int) Math.Pow(n, expNum).ToString().Length + 3;

//     //Добавляем горизонтальную черту в таблицу
//     printLine (".", "-", n, coutWhitespace); Console.WriteLine();

//     //Печпть листа элементов
//     Console.Write("|"); printList (outList, coutWhitespace); Console.WriteLine();
    
//     //Добавляем горизонтальную черту в таблицу
//     printLine (".", "-", n, coutWhitespace); Console.WriteLine();

//     //Печать листа чисел степени e = 3
//     Console.Write("|"); printList (outListN, coutWhitespace); Console.WriteLine();

//     //Добавляем горизонтальную черту в таблицу
//     printLine ("-", "-", n, coutWhitespace);
// }

// //Метод печати горизонтальной линии таблицы 
// void printLine (string a, string b, int count, int n) {
//     int s = 1;
//     while (s <= count) {
//        Console.Write(a + new string(char.Parse(b), n));
//        s++;
//     }
// }

// //Метод печати строки таблицы из листа 
// void printList (List<int> inList, int size) {
//     inList.ForEach(i => {
//         //Определяем нужное количество пробелов после числа
//         int ss = size - i.ToString().Length - 2;

//         //Выводим числа с добавлением пробелов в конце
//         Console.Write(String.Format(" {0} " + new string(' ', ss) + "|", i));
//     });
// }

// //Метод создания листа чисел степени e = 3 из исходного листа
// List<int> addLisdtСube (List<int> inList, int n) {
//     List<int> resultList = new List<int>();
//     inList.ForEach(i => {
//         //Добавляем числа степени e = 3 во второй лист
//         resultList.Add((int) Math.Pow(i, n));
//     });

//     return resultList;
// }
 
// Console.Write("Введите число: ");
// string input = Console.ReadLine() ?? "";
// Console.Write("Введите степень: ");
// string expo = Console.ReadLine() ?? "";
 
// if (input != "" && expo != "") {
//     List<int> listOut = genericList (input);
//     linePrint(listOut, input, expo);
// } else {
//     Console.Write("Ошибка ввода, пустое значение");
// }

//Код №2. Упрощенный
//Метод подготовки набора чисел степени е = 3 и вывод на печать таблицы
void tablePrint (string num, string exp) {
    int n = int.Parse(num);
    int expNum = int.Parse(exp);
   
    Console.WriteLine($"Таблица чисел стени {expNum} от 1 до {n}:");

    //Определяем ширину колонки по размеру самого большого числа
    int whitT = (int) Math.Pow(n, expNum).ToString().Length + 2;

    //Добавляем горизонтальную черту в таблицу
    Console.WriteLine( printLine (".", "-", n, whitT));

    //Печать списка чисел степени 1
    Console.WriteLine(printList (n, 1, whitT));
    
    //Добавляем горизонтальную черту в таблицу
    Console.WriteLine(printLine (".", "-", n, whitT));

    //Печать списка чисел степени e = 3
    Console.WriteLine(printList (n, expNum, whitT));

    //Добавляем горизонтальную черту в таблицу
    Console.WriteLine( printLine ("-", "-", n, whitT));
}

//Метод печати горизонтальной линии таблицы 
string printLine (string a, string b, int n, int size) {
    int s = 1;
    string result = "";
    while (s <= n) {
       result += a + new string(char.Parse(b), size);
       s++;
    }

    return result;
}

//Метод печати строки таблицы
string printList (int n, int exp, int size) {
    int i = 1;
    string result = "|";
    while (i <= n) {
        int val = (int) Math.Pow(i, exp);
        int ss = size - val.ToString().Length - 1;
        result += String.Format(" {0}" + new string(' ', ss) + "|", val);
       i++;
    }   

    return result;
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
Console.Write("Введите степень: ");
string expo = Console.ReadLine() ?? "";
 
if (input != "" && expo != "") {
    tablePrint(input, expo);
} else {
    Console.Write("Ошибка ввода, пустое значение");
}
