// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.

// матрица 4х2 Х матрица 2х3 == матрица 4х3

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

int[,] MultiplicationMatrixs(int[,] matr1, int[,] matr2)
{
    int[,] resultMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return resultMatrix;
}

int[,] matrix1 = CreateMatrixRndInt(4, 2, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(2, 3, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] resultMatr = MultiplicationMatrixs(matrix1, matrix2);
    PrintMatrix(resultMatr);
}
else Console.WriteLine("Число строк первой матрицы не равно числу столбцов второй матрицы");