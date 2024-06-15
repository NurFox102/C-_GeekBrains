// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Write("Введите строку: ");
string? str = Console.ReadLine();
if (str == null) {str = "";}
string stringLower = str.ToLower();
Console.Write($"{str} -> {stringLower}\n");

string str2 = "AaBbCcDdEeGg";
string stringLower2 = str2.ToLower();
Console.Write($"{str2} -> {stringLower2}\n");