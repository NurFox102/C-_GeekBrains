// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// В этом варианте меняются местами только элементы
// 532 12 321 125 13   =>   12 125 321 12 532
Main();

void Main()
{   
    int arraySize = ReadInt("Введите длину массива: ");      // Задаём длину массиву
    int[] array = GenerateArray(arraySize, 1, 1000);         // Создаётся и заполняется массив числами от 1 до 999
    Console.WriteLine("[" + string.Join(" ", array) + "]");  // Выводится на экран массив

    int[] array2 = ReversalArray(array);                     // Создаётся второй массив и заполняется перевёрнутым первым массивом
    Console.WriteLine("[" + string.Join(" ", array2) + "]"); // Выводит на экран новый второй массив
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} // Выводит message на экран и возвращает число вводимое с клавиатуры

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(minRange, maxRange);
    return array;
} // Заполняет массив числами

int[] ReversalArray(int[] array)
{   
    int[] tempArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = array[array.Length - 1 - i];
    }
    return tempArray;
} // Переворачивает массив