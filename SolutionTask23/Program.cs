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
void linePrint (List<int> outList, string num) {
    int n = int.Parse(num);
    
    //Создание листа кубов
    List<int> outListN = addLisdtСube (outList);
    
    //Вывод строки таблицы со списоk числел от 1 до N и параллельно создание списка их кубов
    Console.WriteLine($"Таблица кубов чисел от 1 до {n}:");

    //Определяем длинну самого большого числа
    int coutWhitespace = (int) Math.Pow(n, 2).ToString().Length + 3;

    //Добавляем горизонтальную черту в таблицу
    printLine (".", "-", n, coutWhitespace); Console.WriteLine();

    //Печпть листа элементов
    Console.Write("|"); printList (outList, coutWhitespace); Console.WriteLine();
    
    //Добавляем горизонтальную черту в таблицу
    printLine (".", "-", n, coutWhitespace); Console.WriteLine();

    //Печать листа кубов
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
void printList (List<int> inList, int n) {
    inList.ForEach(i => {
         //Определяем нужное количество пробелов после числа
        int ss = n - i.ToString().Length - 2;

        //Выводим числа с добавлением пробелов в конце
        Console.Write(String.Format(" {0} " + new string(' ', ss) + "|", i));
    });
}

//Метод создания листа кубов из исходного листа
List<int> addLisdtСube (List<int> inList) {
    List<int> resultList = new List<int>();
    inList.ForEach(i => {
        //Добавляем кубы во второй лист
        resultList.Add((int) Math.Pow(i, 3));
    });

    return resultList;
}
 
Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
 
if (input != "") {
    List<int> listOut = genericList (input);
    linePrint(listOut, input);
} else {
    Console.Write("Ошибка ввода, пустое значение");
}
