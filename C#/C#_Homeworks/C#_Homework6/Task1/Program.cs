// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

Main();

void Main()
{
    char[,] array = { { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', '!' }, { 'W', 'h', 'a', 't', '=', 's', ' ', 'u', 'p', '?', '+', '+' } };

    string str1 = new string(ArrayFromMatrix(array));
    string str2 = StringFromMatrix(array);
    string str3 = string.Join("", ArrayFromMatrix(array));
    string str4 = string.Concat(ArrayFromMatrix(array));

    PrintResult(1, str1);
    PrintResult(2, str2);
    PrintResult(3, str3);
    PrintResult(4, str4);

}

string StringFromMatrix(char[,] array)
{
    string stringFromMatrix = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == '=')
                stringFromMatrix += "'";
            else if (array[i, j] == '+')
                continue;
            else
                stringFromMatrix += array[i, j];
        }
        stringFromMatrix += "\n";
    }
    return stringFromMatrix;
}


char[] ArrayFromMatrix(char[,] array)
{
    char[] arrayFromMatrix = new char[array.Length];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == '=')
                arrayFromMatrix[index] = '\'';
            else if (array[i, j] == '+')
                continue;
            else
                arrayFromMatrix[index] = array[i, j];
            index++;
        }
        arrayFromMatrix[index] = '\n';
        index++;
    }
    return arrayFromMatrix;
}

void PrintResult(int num, string str)
{
    Console.Write($"{num}\n{str}\n");
}