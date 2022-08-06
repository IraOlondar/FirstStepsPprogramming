/**
* Сортировка массива пузырьком, вставками, подсчетом и получение разница между минимальным и максимальным значениями
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray () {
    int i = 0;
    int n = 123;
    int[] array = new int[n];

    while (i < n) {
        array[i++] = numberSintezator.Next(0, 100);
    }

    return array;
}

//Разница между минимальным и максимальным значениями
int CalculateTask (int[] arr) {
    return arr[arr.Length -1] - arr[0];
}

//Сортировка массива методом пузырька
int[]  SortBubble (int[] arr) {
    int i, j, tmp, is_swap = 0;

    for (i = 0; i < arr.Length; i++) {
        is_swap = 0;
        for (j = 0; j < arr.Length - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;
                is_swap = 1;
            }
        }
        if (is_swap == 0) {
            break;
        }     
    }

    return arr;
}


//Сортировка массива вставками
int[]  SortInsertion(int[] arr) {
    int i, j, tmp, x;

    for (i = 1; i < arr.Length; i++)
    {
        x = arr[i];
        j = i;
        while (j > 0 && arr[j - 1] > x)
        {
            tmp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = tmp;
            j -= 1;
        }
        arr[j] = x;
    }

    return arr;
}

//Сортировка массива подсчетом
int[]  SortCounting(int[] arr) {
    int max = arr.Max();
    int min = arr.Min();

    int[] count = new int[max - min + 1];
    int z = 0;

    for (int i = 0; i < count.Length; i++) {
        count[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++) {
        count[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++) {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }

    return arr;
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
DateTime timePoint;

int[] intArr = GenArray();
Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");
Print(intArr);

timePoint = DateTime.Now;
int[] sortArray = SortBubble(intArr);
Console.WriteLine();
Console.WriteLine($"Сортировка пузырьком (Execution time {DateTime.Now - timePoint}):");
Print(sortArray);
Console.WriteLine();

timePoint = DateTime.Now;
sortArray = SortInsertion(intArr);
Console.WriteLine($"Сортировка вставками (Execution time {DateTime.Now - timePoint}):");
Print(sortArray);

Console.WriteLine();
timePoint = DateTime.Now;
sortArray = SortCounting(intArr);
Console.WriteLine($"Сортировка подсчетом (Execution time {DateTime.Now - timePoint}):");
Print(sortArray);

int difference = CalculateTask(intArr);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением элементов равна: {difference}");
