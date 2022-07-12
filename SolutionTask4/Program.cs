/**
* Молучение максимального числа из введенных
*
*/
Console.WriteLine("вводите последовательно числа через пробел:");
string? str = Console.ReadLine() ?? "";
int[] arr = str.Split(' ').Select(int.Parse).ToArray();

if (arr.Length != 0) {
    int max = arr[0];
    foreach (int num in arr) {
        if (max < num) {
            max = num;
        }
    }
    string maxText = "max: ";
    maxText += max; 
    Console.WriteLine(maxText);
}
