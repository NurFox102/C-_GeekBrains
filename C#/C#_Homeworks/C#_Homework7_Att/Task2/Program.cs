// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

void Main()
{
    int m = ReadInt("Введите первое число: ");
    int n = ReadInt("Введите второе число: ");
    Console.Write($"A({m}, {n}) = {AkkermanFunction(m, n)}");
}

Main();

int ReadInt(string message)
{
    Console.Write(message);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) { return n + 1; }
    else if (n == 0) { return AkkermanFunction(m - 1, 1); }
    else { return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)); }
}