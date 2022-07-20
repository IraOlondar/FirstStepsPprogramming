/**
* Вывод таблицы кубов чисел от 1 до N
*
*/

//Метод генерации набора чисел от 1 до N
List<int> genericList (string input) {
    int n = int.Parse(input);
    int s = 1;
    List<int> lineList = new List<int>();

    //Заполенние листа числами
    while (s <= n) {
       lineList.Add(s);
       s++;
    }

    return lineList;
}

//Метод подготовки кубов набора чисел и вывод на печать таблицы
void linePrint (List<int> outList, string num, string exp) {
    int n = int.Parse(num);
    int expNum = int.Parse(exp);
    
    //Создание листа кубов
    List<int> outListN = addLisdtСube (outList, expNum);
    
    //Вывод строки таблицы со списоk числел от 1 до N и параллельно создание списка их кубов
    Console.WriteLine($"Таблица чисел стени {expNum} от 1 до {n}:");

    //Определяем длинну самого большого числа
    int coutWhitespace = (int) Math.Pow(n, expNum).ToString().Length + 3;

    //Добавляем горизонтальную черту в таблицу
    printLine (".", "-", n, coutWhitespace); Console.WriteLine();

    //Печпть листа элементов
    Console.Write("|"); printList (outList, coutWhitespace); Console.WriteLine();
    
    //Добавляем горизонтальную черту в таблицу
    printLine (".", "-", n, coutWhitespace); Console.WriteLine();

    //Печать листа чисел степени e = 3
    Console.Write("|"); printList (outListN, coutWhitespace); Console.WriteLine();

    //Добавляем горизонтальную черту в таблицу
    printLine ("-", "-", n, coutWhitespace);
}

//Метод печати горизонтальной линии таблицы 
void printLine (string a, string b, int count, int n) {
    int s = 1;
    while (s <= count) {
       Console.Write(a + new string(char.Parse(b), n));
       s++;
    }
}

//Метод печати строки таблицы из листа 
void printList (List<int> inList, int size) {
    inList.ForEach(i => {
        //Определяем нужное количество пробелов после числа
        int ss = size - i.ToString().Length - 2;

        //Выводим числа с добавлением пробелов в конце
        Console.Write(String.Format(" {0} " + new string(' ', ss) + "|", i));
    });
}

//Метод создания листа чисел степени e = 3 из исходного листа
List<int> addLisdtСube (List<int> inList, int n) {
    List<int> resultList = new List<int>();
    inList.ForEach(i => {
        //Добавляем числа степени e = 3 во второй лист
        resultList.Add((int) Math.Pow(i, n));
    });

    return resultList;
}
 
Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
Console.Write("Введите степень: ");
string expo = Console.ReadLine() ?? "";
 
if (input != "" && expo != "") {
    List<int> listOut = genericList (input);
    linePrint(listOut, input, expo);
} else {
    Console.Write("Ошибка ввода, пустое значение");
}
