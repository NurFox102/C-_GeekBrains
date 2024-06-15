// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Пример

//  2 3 4 3   
//  4 3 4 1    =>  2 + 3 + 5 = 10
//  2 9 5 4

void Main()
{
    int row = ReadInt("Ввведите количество строк: ");
    int col = ReadInt("Ввведите количество столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, 0, 10);
    PrintMatrix(matrix);

    System.Console.WriteLine(SumOnMainDiag(matrix));
}

// int SumOnMainDiag(int[,] matrix)
// {
//     int sum = 0;

//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//         sum += matrix[i, i];

//     return sum;
// }


int SumOnMainDiag(int[,] matrix)
{
    int sum = 0;
    int minIter = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    
    for (int i = 0; i < minIter; i++)
        sum += matrix[i, i];

    return sum;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            Console.Write(matrixForPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GenerateMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);

    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();