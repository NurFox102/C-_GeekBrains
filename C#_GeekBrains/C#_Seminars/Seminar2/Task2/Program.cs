/*
Напишите программу, которая принимает на вход
трёхзначное число и возводит вторую цифру этого
числа в степень, равную третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1

*/

Console.Write("Введите трёхзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99 && number < 1000)
{
    int firstNumber = (number / 10) % 10;
    int secondNumber = number % 10;
    int temp = firstNumber;
    for (int i = 1; i < secondNumber; i++) {
        firstNumber = firstNumber * temp;
    }
    Console.Write(firstNumber);
}
else
{
    Console.Write("Нужно ввести трёхзначное число!\nПопробуйте заново.");
}