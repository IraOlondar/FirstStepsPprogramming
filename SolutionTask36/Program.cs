/**
* Cумму элементов, стоящих на нечётных позициях и вывод элементов имеющих пару
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray () {
    int i = 0;
    int n = 123;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(-99, 100);
        i++;
    }

    return array;
}

//Считаем количество элементов
int CalculateTask (int[] arr) {
    int i = 1;
    int summ = 0;

    while (i < arr.Length) {
        summ += arr[i];
        i += 2;
    }
    return summ;
}

//Сортировка массива методом пузырька
int[]  SortBubble (int[] arr) {
    int i, j, tmp;
    int is_swap = 0;

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

//Вывод элементов массива имеющих пару
void  StarTask (int[] arr) {
    int i = 0;
    int old_value = arr[0];
    bool is_first = true;
    string valls = "";
    
    while (i < arr.Length - 1) {
        if (arr[i] == arr[i + 1] && (is_first ? true : old_value != arr[i])) {
            old_value = arr[i];
            valls += (is_first ? "" : ", ") + arr[i];
            i += 2;

            if (is_first) 
                is_first = false;

        } else {
            i++;
        }
    }

    if (valls.Length > 0) {
        Console.Write("Элементы со значениями: ");
        Console.Write(valls);
        Console.Write(" имеют пару");
    } else {
        Console.Write("Пар одинаковых элементов нет");
    }
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

int[] intArr = GenArray();
int summa = CalculateTask(intArr);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");
Print(intArr);

Console.WriteLine();
Console.WriteLine($"Cумма элементов на нечетных позициях равна {summa}");

int[] sortArray = SortBubble(intArr);

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Print(sortArray);
Console.WriteLine();
StarTask(sortArray);