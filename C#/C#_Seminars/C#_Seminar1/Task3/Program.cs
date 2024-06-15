/*
Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17
*/

Console.Write("Введите трёхзначное целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int firstNumber = number / 100;
int secondNumber = number % 10;
int sum = firstNumber + secondNumber;
Console.Write(sum);