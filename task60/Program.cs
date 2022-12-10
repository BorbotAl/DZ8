// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DMatrixInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int number = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                matrix[i, j, m] = number;
                number++;
            }

        }
    }
    return matrix;
}

void PrintMatrixInRow(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                Console.WriteLine($"{matrix[i, j, m]} ({i}, {j}, {m})");
            }
        }
    }
}

Console.WriteLine("Введите параметры трёхмерного массива");
Console.Write("Введите длину массива: ");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину трёхмерного массива: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите глубину трёхмерного массива: ");
int userDepth = Convert.ToInt32(Console.ReadLine());

if (userRows * userColumns * userDepth < 90)
{
    int[,,] userMatrix3D = Create3DMatrixInt(userRows, userColumns, userDepth);
    PrintMatrixInRow(userMatrix3D);
}
else Console.WriteLine("Невозможно создать трёхмерный массив из неповторяющихся двузначных чисел");