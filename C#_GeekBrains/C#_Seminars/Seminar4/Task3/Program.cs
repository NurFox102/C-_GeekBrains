// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231



Main();

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    if (arraySize < 0 || arraySize > 9)
    {
        Console.WriteLine("Некорректный размер массива");
        return;
    }
    int[] array = GenerateArray(arraySize, 0, 9);
    //PrintArray(array);
   

    Console.WriteLine("[" + string.Join(", ", array) + "]");

    Console.WriteLine(ArrayToInt(array));

    int num = Convert.ToInt32(string.Join("", array)); // Объяснение на 37-40 строках. 
    Console.WriteLine("\n" + num);                     

    int num1 = Convert.ToInt32(string.Concat(array));   // Есть ещё одна функция string.Concat(array). Он объединяет все 
    Console.WriteLine("\n" + num);                     // элементы массива. В отличии от Join разделитель не нужно указывать                                           


    // Есть метод:
    // string.Join("указывается разделитель", указывается массив);
    // string.Join(" ", array);
    // он объединяет все элементы массива в строку и возвращает их через разделитель 

}



// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//         Console.Write(arrayForPrint[i] + " ");

//     Console.WriteLine();
// }



int ArrayToInt(int[] array)
{
    int number = 0;
    int mult = 1;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        number += array[i] * mult;
        mult *= 10;
    }

    return number;
}


int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}



int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange + 1);
    return tempArray;
}