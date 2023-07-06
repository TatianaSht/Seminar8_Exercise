// Задача 58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void Main()
{
    int row = ReadInt("Введите количество строк для матрицы 1: ");
    int columnAndRow = ReadInt("Введите количество столбцов для матрицы 1 (равно количеству строк матрицы 2): ");
    int column = ReadInt("Введите количество столбцов для матрицы 2: ");

    int[,] firstMatrix = new int[row, columnAndRow];
    FillArray(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("Матрица 1:");
    PrintArray(firstMatrix);

    int[,] secomdMatrix = new int[columnAndRow, column];
    FillArray(secomdMatrix);
    Console.WriteLine();
    Console.WriteLine("Матрица 2:");
    PrintArray(secomdMatrix);

    int[,] resultMatrix = new int[row, column];
    ProductMatrix(firstMatrix, secomdMatrix, resultMatrix);
    Console.WriteLine();
    Console.WriteLine("Произведение матрицы 1 и матрицы 2: ");
    PrintArray(resultMatrix);
}


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void ProductMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secomdMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Main();