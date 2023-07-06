// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Main()
{
    Console.WriteLine("Введите значения размера трехмерного массива для Х, У, Z (X * Y * Z должно быть <= 90!): ");
    int x = ReadInt("Введите число для X: ");
    int y = ReadInt("Введите число для Y: ");
    int z = ReadInt("Введите число для Z: ");
    Console.WriteLine();
    int[,,] array = new int[x, y, z];
    FillArray(array);
    PrintArray(array);
}


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    if (temp.Length <= 90)
    {
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                    }
                }
            }
        }

        int count = 0;
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                    array[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    int i = 0;
    int j = 0;
    int k = 0;
    if ((array.GetLength(0) * array.GetLength(1) * array.GetLength(2)) <= 90 && array[i, j, k] != 0)
    {
        for (i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
            {
                for (k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Введенные размеры превышают допустимое значение (X * Y * Z <= 90!)");
}


Main();