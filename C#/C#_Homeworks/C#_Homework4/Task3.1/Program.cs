// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// В этом варианте помимо мест элементов в массиве так же меняется вид самих элементов:
// 532 12 321   =>   123 21 235



// есть проблемы с числами, которые оканчиваются на 0.
// Например: 
// 10 100 250 50 840   =>   48 5 52 1 1

//                  ЧТО ДЕЛАТЬ!?



Main();

void Main()
{   
    int arraySize = ReadInt("Введите длину массива: ");       // Задаём длину массиву
    int[] array = GenerateArray(arraySize, 1, 1000);          // Создаётся и заполняется массив числами от 1 до 999
    Console.WriteLine("[" + string.Join(" ", array) + "]");   // Выводится на экран массив

    int[] array2 = ReversalArray(array);                      // Создаётся второй массив и заполняется перевёрнутым первым массивом 
    Console.WriteLine("[" + string.Join(" ", array2) + "]");  // с перевёрнутыми элементами. Выводит на экран новый второй массив
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

int ReversalNumbers(int number)
{   
    int reversal = 0;
    while (number != 0)
    {
        reversal = reversal * 10 + number % 10;
        number /= 10;
    }

    return reversal;
} // Переворачивает число (123 => 321)

int[] ReversalArray(int[] array)
{   
    int[] tempArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = ReversalNumbers(array[array.Length - 1 - i]);
    }
    return tempArray;
} // Переворачивает массив и переворачивает элементы(123 => 321)