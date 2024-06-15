// Задача 3: Показ наибольшей цифры числа

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число из отрезка [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int firstDigit = number / 10;
        int secondDigit = number % 10;
        int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; Console.WriteLine(maxDigit);
    }
}