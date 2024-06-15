/*

Дано натуральное
число в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива
должен быть равен количеству цифр.

425 => [4 2 5]
8741 => [8 7 4 1]
4 => [4]

*/

//   Первый вариант кода
Console.Write($"{"Введите число в диапазоне от 1 до 100 000: "}");
int num = Convert.ToInt32(Console.ReadLine());
int reversalNum = 0;
int index = 0;

while (num != 0)
{   
    reversalNum = reversalNum * 10 + num % 10;
    num /= 10;
    index_count += 1;
}

int[] array = new int[index_count];

for (int i = 0; i < array.Length; i++)
{
    array[i] = reversalNum % 10;
    reversalNum /= 10;
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{   
    if (i == array.Length-1)
    Console.Write($"{array[i]}");
    else
    Console.Write($"{array[i]} ");
}
Console.Write("]");


//   Второй вариант кода без переворота числа 1564 -> 4651
/*
Console.Write($"{"Введите число в диапазоне от 1 до 100 000: "}");
int num = Convert.ToInt32(Console.ReadLine());
int indexLength = 0;
int temp = num;

while (temp != 0)
{   
    temp /= 10;
    indexLength += 1;
}

int[] array = new int[indexLength];

for (int i = array.Length-1; i >= 0; i--)
{
    array[i] = num % 10;
    num /= 10;
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{   
    if (i == array.Length-1)
    Console.Write($"{array[i]}");
    else
    Console.Write($"{array[i]} ");
}
Console.Write("]");
*/