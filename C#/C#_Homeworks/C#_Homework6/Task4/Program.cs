// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Main(System.Text.Encoding.GetEncoding("utf-16"));

void Main(System.Text.Encoding encoding) 
{
    Console.InputEncoding = encoding;
    Console.WriteLine("Введите строку: ");
    string someString = ReadString1();
    int space = SpaceCounter(someString);
    string[] str = CoupArray(ArrayFromString(space, someString));
    string str2 = string.Join(" ", str);
    Console.WriteLine(str2);

    // Console.WriteLine(string.Join(" ", CoupArray(ArrayFromString(space, someString))));
}

string ReadString1()
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

int SpaceCounter(string str)
{
    int size = 0;
    foreach (char e in str)
    {
        if (e == ' ')
            size++;
    }
    if (size != 0)
        size += 1;
    return size;
}

string[] ArrayFromString(int size, string str)
{
    string[] arrayString = new string[size];
    int indexElement = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
            arrayString[indexElement] += str[i];
        else
            indexElement++;
    }
    return arrayString;
}

string[] CoupArray(string[] str)
{
    string[] str2 = new string[str.Length]; 
    int indexForStr2 = 0;
    for (int i = str.Length - 1; i >= 0; i--)
    {
        str2[indexForStr2] = str[i];
        indexForStr2++;
    }
    return str2;
}