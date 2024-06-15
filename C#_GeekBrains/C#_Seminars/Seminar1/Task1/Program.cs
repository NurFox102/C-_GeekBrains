/*
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет

*/
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.Write($"{"Да, первое число является квадратом второго"} ");
}
else
{
    Console.Write($"{"Нет, первое число не является квадратом второго"} ");
}