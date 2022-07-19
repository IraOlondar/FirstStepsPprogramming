/**
* Вывод таблицы квадратов чисел от 1 до N
*
*/

//Метод 1
//Метод генерации набора чисел от 1 до N
string genericList (string input) {
    int n = int.Parse(input);
    int s = 1;
    string lineList = "";

    //Заполенние строки числами
    while (s <= n) {
       lineList = lineList + s + "\t";
       s++;
    }

    return lineList;
}

//Метод подготовки квадратов набора чисел и вывод на печать таблицы
void linePrint (string outList, string num) {
    int n = int.Parse(num);
    string outListN = "";
   
   //Вывод строки таблицы со списком числел от 1 до N
    Console.Write(outList);

    //Cоздание списка их квадратов
    int s = 1;
    while (s <= n) {
       outListN = outListN + Math.Pow(s, 2).ToString() + "\t";
       s++;
    }
    Console.WriteLine();
    
    //Вывод второй чтроки таблицы с квадратами чисел от 1 до N
    Console.Write(outListN);
    
}
 
Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
 
if (input != "") {
    string listOut = genericList (input);
    linePrint(listOut, input);
} else {
    Console.Write("Ошибка ввода, пустое значение");
}


// //Метод 2
// //Метод генерации набора чисел от 1 до N
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

// //Метод подготовки квадратов набора чисел и вывод на печать таблицы
// void linePrint (List<int> outList) {
//    List<int> outListN = new List<int>();
   
//    //Вывод строки таблицы со списоk числел от 1 до N и параллельно создание списка их квадратов
//    outList.ForEach(i => {
//         Console.Write("{0}\t", i);
//         outListN.Add((int) Math.Pow(i, 2));
//    });
//     Console.WriteLine();
    
//     //Вывод второй cтроки таблицы с квадратами чисел от 1 до N
//     outListN.ForEach(i => Console.Write("{0}\t", i));
    
// }
 
// Console.Write("Введите число: ");
// string input = Console.ReadLine() ?? "";
 
// if (input != "") {
//     List<int> listOut = genericList (input);
//     linePrint(listOut);
// } else {
//     Console.Write("Ошибка ввода, пустое значение");
// }
