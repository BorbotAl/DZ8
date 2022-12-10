// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}, ");
            else Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumOfRows(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int IndexMinSum(int[] array)
{
    int indexOfMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[indexOfMin]) indexOfMin = i;
    }
    return indexOfMin;
}

int[,] userMatrix = CreateMatrixRndInt(5, 2, 0, 10);
PrintMatrix(userMatrix);
Console.WriteLine();
int[] sumOfRows = SumOfRows(userMatrix);
PrintArray(sumOfRows);
int result = IndexMinSum(sumOfRows);
Console.Write($"Номер строки с наименьшей суммой элементов --> {result + 1}");