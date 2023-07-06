// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void Main()
{
    int sizeMatrix = ReadInt("Введите размер матрицы (число от 2 до 10): ");
    int direction = ReadInt("Введите число для направления спирали (1 - по часовой стрелке, 2 - против): ");
    int[,] matrix = new int[sizeMatrix, sizeMatrix];
    FillSpiralMatrix(matrix, direction);
    PrintMatrix(matrix, sizeMatrix, direction);
}


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void FillSpiralMatrix(int[,] matrixSnake, int vector)
{
    {
        int temp = 1;
        int i = 0;
        int j = 0;
        while (temp <= matrixSnake.GetLength(0) * matrixSnake.GetLength(1))
        {
            matrixSnake[i, j] = temp;
            temp++;
            if (vector == 1)
            {
                if (i <= j + 1 && i + j < matrixSnake.GetLength(1) - 1)
                {
                    j++;
                }
                else if (i < j && i + j >= matrixSnake.GetLength(0) - 1)
                {
                    i++;
                }
                else if (i >= j && i + j > matrixSnake.GetLength(1) - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
            if (vector == 2)
            {
                if (j <= i + 1 && i + j < matrixSnake.GetLength(0) - 1)
                {
                    i++;
                }
                else if (j < i && i + j >= matrixSnake.GetLength(1) - 1)
                {
                    j++;
                }
                else if (j >= i && i + j > matrixSnake.GetLength(0) - 1)
                {
                    i--;
                }
                else
                {
                    j--;
                }
            }
        }
    }
}


void PrintMatrix(int[,] matrixForPrint, int num1, int num2)
{
    if (num1 >= 2 && num1 <= 10 && num2 >= 1 && num2 <= 2)
    {
        for (int i = 0; i < matrixForPrint.GetLength(0); i++)
        {
            for (int j = 0; j < matrixForPrint.GetLength(1); j++)
            {
                if (matrixForPrint[i, j] > 9) 
                {
                    Console.Write(matrixForPrint[i, j] + "\t");
                }
                else Console.Write($"0{matrixForPrint[i, j]}" + "\t");
                // Console.Write(matrixForPrint[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Введено неверное значение параметров матрицы!");
    }
}


Main(); 