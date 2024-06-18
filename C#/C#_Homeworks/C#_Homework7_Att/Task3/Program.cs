// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int size = ReadInt("Введите длину массива: ");
    int[] array = new int[size];
    Random rand = new Random();

    GenerateArray(array, 0, rand);
    Console.WriteLine("\n" + string.Join(" ", array) + "\n");
    PrintArray(array, 0);
}

Main();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void GenerateArray(int[] array, int i, Random rand)
{
    if (i == array.Length)
    {
        return;
    }
    array[i] = rand.Next(0, 100);
    GenerateArray(array, i += 1, rand);
}

void PrintArray(int[] array, int i)
{
    if (i > array.Length - 1)
    {
        return;
    }
    else 
    {
        Console.Write(array[array.Length-1-i] + " ");
        PrintArray(array, i += 1);
    }
}