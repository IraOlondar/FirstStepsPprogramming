/**
* Создание трёхмерного массива из неповторяющихся двузначными числами. 
* Построчный вывод массива, с указанием индексов каждого элемента.
*
*/

System.Random numberSintezator = new Random();

//Генерируем трехмерный массив
int[,,] GenThreeDimensionalArray (int a, int b, int c, int min, int max) {
    int[,,] array = new int[a, b, c];
    List<int> numsList = new List<int>();
    int val;

    for (int i = 0; i < a; i++) {
        for (int j = 0; j < b; j++) {
            for (int k = 0; k < c; k++) {
                do {
                    val = numberSintezator.Next(min, max);
                } while (numsList.Contains(val));

                array[i,j,k] = val;
                numsList.Add(val);
            }
        }
    }
    return array;
}

//Вывод на печать трехмерного массива
void PrintThreeDimensionalArray (int[,,] arr) {
    int y = 0;
    Console.WriteLine();
    for(int i =0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            for(int k = 0; k < arr.GetLength(2); k++) {
                Console.Write($"{arr[i,j,k]}({i},{j},{k})" + (y++ != arr.Length - 1 ? " " : ""));
            }
            Console.WriteLine(); //Для лучшего визуального восприятия!
        }
    }
}


int[,,] intArrTwoDimensionalArrayFirst = GenThreeDimensionalArray(4, 4, 4, 10, 100);

PrintThreeDimensionalArray(intArrTwoDimensionalArrayFirst);

