/**
* Проверка на кратность 7 и 23 одновременно, введенного числа
* 
*/
Console.WriteLine("введите число:");
string? number = Console.ReadLine();
int b = 7;
int c = 23;
int outNumber = int.Parse(number);

void fun (int number, int b, int c) {
    if (number != null && b != null && c != null) {
        int is_null_b = outNumber  % b;
        int is_null_c = outNumber  % c;
        string iext = "";
        
        if (is_null_b == 0 && is_null_c == 0) {
            iext = "да"; 
        } else {
            iext = "нет"; 
        }
        Console.WriteLine(iext);
    }
}

fun(outNumber, b, c);