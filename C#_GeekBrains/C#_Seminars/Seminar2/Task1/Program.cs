/*
Напишите программу, которая принимает на
вход трёхзначное число и удаляет вторую
цифру этого числа.
Примеры
a = 256 => 26
a = 891 => 81
*/

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;
    int sum = firstNumber * 10 + secondNumber;
    Console.Write(sum);
}
else
{
    Console.Write("Нужно ввести трёхзначное число!\nПопробуйте заново.");
}