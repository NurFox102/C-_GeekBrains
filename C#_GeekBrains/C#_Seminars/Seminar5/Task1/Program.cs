// Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

// Пример

//  2 3 4 3         4 3 16  3 
//  4 3 4 1    =>   4 3 4  1
//  2 9 5 4         4 9 25 4

void Main()
{
    int row = ReadInt("Ввведите количество строк: ");
    int col = ReadInt("Ввведите количество столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, 0, 10);
    PrintMatrix(matrix);

    ChangeMatrix(matrix);
    PrintMatrix(matrix);
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
        for (int j = 0; j < matrix.GetLength(1); j += 2)
            matrix[i, j] *= matrix[i, j];
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
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