/*
Напишите программу, которая выводит третью с
конца цифру заданного числа или сообщает, что
третьей цифры нет.
456 => 6
7812 => 1
91 => Третьей цифры нет
*/

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99)
{
    while (number > 999)
    {
        number /= 10; // number = number / 10;
    }
    Console.Write(number % 10);
}
else
{
    Console.Write("Третьей цифры нет");
}