/**
* Нахождение площади треугольника образованного пересечением 3 прямых
*
*/

//Bзменение языка и региональных параметров для правильной работы double.Parse
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

//Читаем консоль
double[,] ReadSieds () {
    double[,] outArray = new double[3,2];
    
    Console.Write("Введите число K1: ");
    outArray[0,0] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число B1: ");
    outArray[0,1] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число K2: ");
    outArray[1,0] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число B2: ");
    outArray[1,1] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число K3: ");
    outArray[2,0] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число B3: ");
    outArray[2,1] = double.Parse(Console.ReadLine() ?? "");

    return outArray;
}

//Нахождение координат пересечения
double[] GetPointIntersection (double k1, double b1, double k2, double b2) {
    double[] outArray = new double[2];
    
    if (k1 - k2 != 0) { //Проверка на параллельность
        //Нахождение X
        outArray[0] = (b2 - b1)/(k1 - k2);
            
        //Находжение Y
        outArray[1] = k1 * outArray[0] + b1;
    }
    
    return outArray;
}

//Нахождение расстояния между точками
double GetDistance (double coordAX, double coordAY, double coordBX, double coordBY) {
    return Math.Sqrt(Math.Pow((coordAX - coordBX), 2) + Math.Pow((coordAY - coordBY), 2));
}

//Нахождение прощади треугольника по трем сторонам
double GetAreaTriangle (double a, double b, double c) {    
    double p = (a + b + c) / 2; //Порлупеиметр треугольника
    
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

//Выводим результат
void PrintResult (double res) {
    Console.WriteLine("Прощадь треугольника равна: " + Math.Round(res, 2));
}

double[,] inputArray = ReadSieds();

// GetDistance(k1, b1, k2, b2)
double[] pointX12 = GetPointIntersection(inputArray[0,0], inputArray[0,1], inputArray[1,0], inputArray[1,1]);
// GetDistance(k2, b2, k3, b3)
double[] pointX23 = GetPointIntersection(inputArray[1,0], inputArray[1,1], inputArray[2,0], inputArray[2,1]);
// GetDistance(k1, b1, k3, b3)
double[] pointX13 = GetPointIntersection(inputArray[0,0], inputArray[0,1], inputArray[2,0], inputArray[2,1]);

//GetDistance(X12, Y12, X23, Y23)
double distanc12_23 = GetDistance(pointX12[0], pointX12[1], pointX23[0], pointX23[1]);
//GetDistance(X13, Y13, X23, Y23)
double distanc13_23 = GetDistance(pointX13[0], pointX13[1], pointX23[0], pointX23[1]);
//GetDistance(X12, Y12, X13, Y13)
double distanc12_13 = GetDistance(pointX12[0], pointX12[1], pointX13[0], pointX13[1]);

PrintResult(GetAreaTriangle(distanc12_23, distanc13_23, distanc12_13));