// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    int row = ReadInt("Введите количество строк массива: ");
    int column = ReadInt("Введите количество столбцов массива: ");
    int[,] array = new int[row, column];
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    int rowNumber = GetMinSumOfRow(array);
    Console.WriteLine($"Наименьшая сумма чисел в строке - {rowNumber}");
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


int GetMinSumOfRow(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow[i] += array[i, j];
        }
        Console.WriteLine($"Сумма чисел в строке {i + 1} = {sumRow[i]}");
    }

    int sum = sumRow[0];
    int rowMinSum = 0;

    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < sum)
        {
            sum = sumRow[i];
            rowMinSum = i;
        }
    }
    return rowMinSum + 1;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Main();