// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Main();

void Main()
{   
    int arraySize = ReadInt("Введите длину массива: ");     // Задаём длину массиву
    int[] array = GenerateArray(arraySize);                 // Создаётся и заполняется массив
    
    Console.WriteLine("[" + string.Join(" ", array) + "]"); // Выводится на экран массив
    Console.WriteLine(CountEvenNumbers(array));             // Выводится на экран количество чётных чисел в массиве
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} // Выводит message на экран и возвращает число вводимое с клавиатуры

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(100, 1000);
    return array;
} // Заполняет массив числами от 100 до 999

int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach(int e in array)
    {
        if(CheckEven(e))
            count++;
    }
    return count;
} // Подсчитывается количество чётных чисел в массиве

bool CheckEven(int number)
{
    if (number % 2 == 0)
        return true;
    return false;
} // Проверяется число на чётность. В случае, если число чётное, возвращается true.