// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
void Main()
{
    int first_Number_M = ReadInt("Введите первое число: ");
    int second_Number_N = ReadInt("Введите второе число: ");
    PrintNumber(first_Number_M, second_Number_N);
}

Main();

int ReadInt(string message)
{
    Console.Write(message);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void PrintNumber(int first_M, int second_N)
{
    if (first_M > second_N) {return;}
    Console.Write(first_M + " ");
    PrintNumber(first_M + 1, second_N);
}