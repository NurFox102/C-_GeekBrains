// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

using System.Runtime.CompilerServices;

Main();

void Main(){
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 50);

    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine(CountPrimes(array));
    

}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange + 1);
    return tempArray;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int CountPrimes(int[] array)
{
    int count = 0;
    foreach (int e in array)
        if (IsPrime(e))
            count++; 
    return count;
}

bool IsPrime(int number) 
{
    if (number < 2)
        return false;
    
    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0)
            return false;

    return true;
}