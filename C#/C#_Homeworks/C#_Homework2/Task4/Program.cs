/*
Задача 4: 
Напишите программу, которая на вход принимает натуральное число N, а на выходе 
показывает его цифры через запятую.

!!! Отрицательные и нецелые числа натуральными числами не являются.
*/

Console.Write($"{"Введите число: "}");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    if (number > 9)
    {   
        while (number > 9)
        {
            int qtr = 10;
            int temp = number;
            int index = 0;
            while (temp > 9)
            {
                temp /= 10;
                index += 1;
            }
            Console.Write($"{temp + ", "}");
            for (int i = index; i > 1; i--)
            {
                qtr = qtr * 10;
            }
            number = number - temp * qtr;
        }
        Console.WriteLine(number);
    }
    else
    {
        Console.Write(number);
    }

}
else
{
    Console.Write("Нужно ввести натуральное число.");
}