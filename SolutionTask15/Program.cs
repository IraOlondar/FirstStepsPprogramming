/**
* Поиск дня недели по номеру и проверка на то что он выходной
*
*/

string workday = "рабочий день";
string weekend = "выходной";

Dictionary<int, Dictionary<string, string>> dey = new Dictionary<int, Dictionary<string, string>>(){
    [1] = new Dictionary<string, string>() {["понедельник"] = workday},
    [2] = new Dictionary<string, string>() {["вторник"] = workday},
    [3] = new Dictionary<string, string>() {["среда"] = workday},
    [4] = new Dictionary<string, string>() {["четверг"] = workday},
    [5] = new Dictionary<string, string>() {["пятница"] = workday},
    [6] = new Dictionary<string, string>() {["суббота"] = weekend},
    [7] = new Dictionary<string, string>() {["воскресенье"] = weekend},
};

Console.WriteLine("введите номер дня недели:");
string? a = Console.ReadLine();
if (a != "" && a != null) {
    int outA = int.Parse(a); 

    if (outA > 0 && outA < 8) {
        foreach (KeyValuePair<string, string> d in dey[outA]) {
            if (d.Value == weekend) {
                Console.WriteLine("да, {0}, это {1}", d.Key, d.Value);
            } else {
                Console.WriteLine("нет, {0}, это {1}", d.Key, d.Value);
            }
        }
    }
}
