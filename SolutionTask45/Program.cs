/**
* Создание копии массива
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray (int n, int min, int max) {
    int i = 0;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(min, max);
        i++;
    }

    return array;
}

//Создание нового массива
int[] CopyArrayStandartTool (int[] arr) {
    int[] newArray = new int[arr.Length];
    arr.CopyTo(newArray, 0);
    return newArray;
}

//Выводим на печать массив
void Print (int[] arr) {
    int i = 0;
    
    Console.Write("[");
    foreach(int value in arr) {
        Console.Write(value + (i != arr.Length - 1 ? "," : ""));
        i++;
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] intArr = GenArray(13, 0, 10);

Print(intArr);
Print(CopyArrayStandartTool(intArr));

