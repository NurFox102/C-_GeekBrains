// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2



Main();

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 19, 22);
    PrintArray(array);
    Console.WriteLine(CountNumbers(array));

    Console.WriteLine("[" + string.Join(" | ", array) + "]");
    // Есть метод:
    // string.Join("указывается разделитель", указывается массив);
    // string.Join(" ", array);
    // он объединяет все элементы массива в строку и возвращает их через разделитель 

}



int CountNumbers(int[] anyArray)
{   
    int count = 0;

    for (int i = 0; i <anyArray.Length; i++)
    {
        if (anyArray[i] % 1 == 0 && anyArray[i] % 7 == 0)
            count++;
    }
    return count;
}



void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        Console.Write(arrayForPrint[i] + " ");

    Console.WriteLine();
}



int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}



int[] GenerateArray(
    int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange + 1);
    return tempArray;
}