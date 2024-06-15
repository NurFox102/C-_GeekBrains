/*
Задача 2: 
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
*/

Console.Write($"{"Введите координату X: "}");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"{"Введите координату Y: "}");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
    Console.Write($"{"Координаты X и Y должны быть отличными от 0, чтобы узнать четверть плоскости."}");
else
{
    if (x < 0)
    {
        if (y < 0)
            Console.Write($"{"3"}");
        else 
            Console.Write($"{"2"}");
    }
    else
    {
        if (y < 0)
            Console.Write($"{"4"}");
        else
            Console.Write($"{"1"}");
    }
}