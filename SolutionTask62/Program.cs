/**
* Создание спиральной матрицы
*
*/

//Генератор спиральной матрицы
int[,] GenSpiralArray(int n, int m) {
    int i = 0;
    int[,] newArrey = new int[n, m];
    int row = 0;
    int col = 0; 
    int a = 1; 
    int b = 0; 
    int shift = 0; 
    int reserve = m;
    int temp = a;
    while (i++ < n * m) {
        newArrey[row, col] = i;
        if (--reserve == 0) {
            reserve = m * (shift % 2) + n * ((shift + 1) % 2) - (shift / 2 - 1) - 2;
            temp = a;
            a = -b;
            b = temp;
            shift++;
        }
        col += a;
        row += b;
    }
    return newArrey;
}

//Выводим на печать массив
void PrintTwoDimensionalArray (int[,] arr) {
    int i = 0, j = 0;
    int val;
    Console.WriteLine();
    while(i < arr.GetLength(0)) {
        j = 0;
        while(j < arr.GetLength(1)) {
            val = arr[i,j];
            Console.Write(new string(' ', arr[arr.GetLength(0) - 1,arr.GetLength(1) - 1].ToString().Length + 2 - val.ToString().Length));
            Console.Write(val);
            Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
}

PrintTwoDimensionalArray(GenSpiralArray(15,20));
