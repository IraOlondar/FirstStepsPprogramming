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
    List<int> outListN = new List<int>();
    
    //Вывод строки таблицы со списоk числел от 1 до N и параллельно создание списка их кубов
    Console.WriteLine($"Таблица кубов чисел от 1 до {n}:");

    //Определяем длинну самого большого числа
    int coutWhitespace = (int) Math.Pow(n, 2).ToString().Length + 3;

    //Добавляем горизонтальную черту в таблицу
    Console.Write(new string('-',coutWhitespace));
    int s = 2;
    while (s <= n) {
       Console.Write("." + new string('-',coutWhitespace));
       s++;
    }

    Console.WriteLine();

    outList.ForEach(i => {
         //Определяем нужное количество пробелов после числа
        int ss = coutWhitespace - i.ToString().Length - 2;

        //Выводим числа с добавлением пробелов в конце
        Console.Write(String.Format(" {0} " + new string(' ', ss) +"|", i));
        
        //Добавляем кубы во второй лист
        outListN.Add((int) Math.Pow(i, 3));
    });
    
    Console.WriteLine();
    
    //Добавляем горизонтальную черту в таблицу
    Console.Write(new string('-',coutWhitespace));
    s = 2;
    while (s <= n) {
       Console.Write("." + new string('-',coutWhitespace));
       s++;
    }

    Console.WriteLine();

    //Обходим лист кубов
    outListN.ForEach(i => {
        //Определяем нужное количество пробелов после числа
        int ss = coutWhitespace - i.ToString().Length - 2;

        //Вывод второй cтроки таблицы с кубами чисел от 1 до N
        //Выводим числа с добавлением пробелов в конце
        Console.Write(String.Format(" {0} " + new string(' ', ss) +"|", i));
    });

    Console.WriteLine();

    //Добавляем горизонтальную черту в таблицу
    Console.Write(new string('-',coutWhitespace));
    s = 2;
    while (s <= n) {
       Console.Write(new string('-',coutWhitespace + 1));
       s++;
    }
    
}
 
Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
 
if (input != "") {
    List<int> listOut = genericList (input);
    linePrint(listOut, input);
} else {
    Console.Write("Ошибка ввода, пустое значение");
}
