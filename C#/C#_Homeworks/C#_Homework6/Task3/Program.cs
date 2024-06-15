// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
// Пришлось добавить/изменить пару строк, для
// корректного сохранения кириллицы при вводе 
// через Console.ReadLine() в переменной типа string

Main(System.Text.Encoding.GetEncoding("utf-16"));         //добавил
// Main(); БЫЛО

void Main(System.Text.Encoding encoding)                  //добавил
// void Main() БЫЛО
{
    Console.InputEncoding = encoding;                     //добавил
    Console.WriteLine("Введите строку: ");
    char[] str = ArrayFromString(ReadString1());
    if (IsArrayCharPalindrome(str))
        Console.WriteLine("Это строка палиндром");
    else
        Console.WriteLine("Это строка не палиндром");
}

bool IsArrayCharPalindrome(char[] array)
{
    bool isPalindrome = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != array[array.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }
    return isPalindrome;
}

string ReadString1()
{
    string? str1 = Console.ReadLine();
    if (str1 == null)
    {
        str1 = "";
        return str1;
    }
    else
        return str1.ToLower();
}

char[] ArrayFromString(string str)
{   
    int size = 0;

    foreach (char e in str)
    {
        if (e != ' ')                           // Если важны только буквы, то можно тут поменять на Char.IsLetter(e);
            size++;
    }

    char[] arrayChar = new char[size];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')                      // Если важны только буквы, то можно тут поменять на Char.IsLetter(e); 
        {
            arrayChar[j] = str[i];
            j++;
        }
    }

    return arrayChar;
}