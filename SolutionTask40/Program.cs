/**
* Проверка на ртеугольник
*
*/

int sideA = 0;
int sideB = 0;
int sideC = 0;

//Читаем консоль
void ReadSieds () {
    Console.Write("Введите первое число: ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите второе число: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите третье число: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}

//Проверяем на возможность составить треугольник из заданных отрезков
bool TestTiangle (int a, int b, int c) {
    return a + b > c && a + c > b && b + c > a;
}

//Выводим результат
void PrintAnsver (bool answer) {
    Console.WriteLine("С отрезками заданной длинны " + (answer ? "можно" : "нельзя") + " составить треугольник");
}

ReadSieds();
PrintAnsver(TestTiangle(sideA, sideB, sideC));
