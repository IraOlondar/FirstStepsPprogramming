//Считываем точки и возвращаем массив с ними
int[,] readPoint() {
    string? inputLine = Console.ReadLine() ?? "";

    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=")+1);
    
    string coordYLine = inputLine.Substring(inputLine.IndexOf(";")+1);
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=")+1);

    int ccordX = int.Parse(coordXLine);
    int ccordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1,2];

    arrayOut[0,0] = ccordX;
    arrayOut[0,1] = ccordY;

    return arrayOut;
}

//Печатаем номер четверти

void printQuter(int[,] arreyPoint) {
    if (arreyPoint[0,0]>0 && arreyPoint[0,1]>0)
        Console.WriteLine("Первая четверь");
    
    if (arreyPoint[0,0]<0 && arreyPoint[0,1]>0)
        Console.WriteLine("Вторя четверть");

    if (arreyPoint[0,0]<0 && arreyPoint[0,1]<0)
        Console.WriteLine("Третья четверть");

    if (arreyPoint[0,0]>0 && arreyPoint[0,1]<0)
        Console.WriteLine("Четвертая четверть");
}

int[,] arreyPoint = readPoint();

printQuter(arreyPoint);


//Вариант 2
// int[,] readPoint() {
//     string inputLine = Console.ReadLine() ?? "";
//     //Парсим значения x и y из строки запроса и переводим а массив
//     int[] arrayOut = inputLine.Split(";").Select(x => int.Parse(x.Split("=").Last())).ToArray();
    
//     int[,] arrayOut = new int[1,2];

//     //Создаем из массива значений двумерный массив
//     foreach((int val, int i) in arr.Select((val, i)=>(val, i))) { 
//         arrayOut[0,i] = val;
//     }
//     return arrayOut;
// }

// //Печатаем номер четверти

// void printQuter(int[,] arreyPoint) {
//     if (arreyPoint[0,0]>0 && arreyPoint[0,1]>0)
//         Console.WriteLine("Первая четверь");
    
//     if (arreyPoint[0,0]<0 && arreyPoint[0,1]>0)
//         Console.WriteLine("Вторя четверть");

//     if (arreyPoint[0,0]<0 && arreyPoint[0,1]<0)
//         Console.WriteLine("Третья четверть");

//     if (arreyPoint[0,0]>0 && arreyPoint[0,1]<0)
//         Console.WriteLine("Четвертая четверть");
// }

// int[,] arreyPoint = readPoint();

// printQuter(arreyPoint);
