/**
* Посчет четных чисел в массиве и пузырьковая сортировка
*
*/

System.Random numberSintezator = new Random();

//Генерируем массив
int[] GenArray () {
    int i = 0;
    int n = 123;
    int[] array = new int[n];

    while (i < n) {
        array[i] = numberSintezator.Next(100, 1000);
        i++;
    }

    return array;
}

//Считаем количество элементов
int CalculateTask (int[] arr) {
    int i = 0;
    int cout = 0;

    while(i < arr.Length) {
       if (arr[i++] % 2 == 0) {
            cout++;
       }
    }
    return cout;
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
int countPositive = CalculateTask(intArr);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");
Print(intArr);

int[] sortArray = SortBubble(intArr);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Print(sortArray);


Console.WriteLine();
Console.WriteLine($"В массиве {countPositive} четных чисел");