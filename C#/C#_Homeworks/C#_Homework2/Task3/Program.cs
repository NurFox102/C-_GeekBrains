/*
Задача 3: 
Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

Console.Write($"{"Введите число от 10 до 99: "}");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 || number < 10)
{
    Console.Write($"{"Вы ввели недопустимое число."}");
}
else
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    if (firstNumber > secondNumber)
    {
        Console.Write($"{firstNumber}");
    }
    else
    {
        Console.Write($"{secondNumber}");
    }
}