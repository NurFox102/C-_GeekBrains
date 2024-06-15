// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических 
// значений по строкам двумерного массива. 
// Пример

//  2 3 4 3   
//  4 3 4 1    =>  [3 3 5]
//  2 9 5 4
// i = 0; j = 4
// [3,_,_]

void Main()
{
    int row = ReadInt("Ввведите количество строк: ");
    int col = ReadInt("Ввведите количество столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, 0, 10);
    PrintMatrix(matrix);
    PrintArray(AverageArray(matrix));
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

double[] AverageArray(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            averages[i] += matrix[i, j];
        }

        averages[i] /= matrix.GetLength(1);
    }

    return averages;
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