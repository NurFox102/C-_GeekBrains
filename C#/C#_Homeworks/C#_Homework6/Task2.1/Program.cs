// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Main();

void Main()
{   
    Console.Write("Введите строку: ");
    string str = ReadString();
    PrintResult(str,StrToLower(str));
}

void PrintResult(string a, string b)
{
    Console.Write($"{a} => {b}\n");
}

string StrToLower(string a)
{
    a = a.ToLower();
    return a;
}

string ReadString()
{
    string? str = Console.ReadLine();
    if (str == null) 
    {
        str = "";
        return str;
    }
    else 
        return str;
}