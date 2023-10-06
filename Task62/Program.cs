// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;
        }
    }
    return matrix;
}

int[,] SpiralMatrix(int[,] matrix, int rows, int columns)
{
    int max = rows * columns;
    int count1 = 1;
    int count2 = 0;
    int number = 0;
    int i = 0;
    int j = 0;
    while (number != max)
    {
        //2    (2)    4                   2
        while (j != matrix.GetLength(1) - count1)
        {
            number++; // 13
            if (number > max) return matrix;
            matrix[i, j] = number; // 1;1= 13
            j++; // 2
        }
        //2    (2)   4                   2
        while (i != matrix.GetLength(0) - count1)
        {
            number++; // 14
            if (number > max) return matrix;
            matrix[i, j] = number; //1;2 = 14
            i++; // 2
        }
        //0       0
        while (j != count2)
        {
            number++; // 16
            if (number > max) return matrix;
            matrix[i, j] = number; // 2;1 = 16
            j--; // 0
        }
        //     2       2
        while (i != count1)
        {
            number++; // 11
            if (number > max) return matrix;
            matrix[i, j] = number; // 2;0 = 11
            i--; // 1
        }
        count1++; // 2
        count2++; // 1
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixInt(5, 5);
int[,] spiralMatrix = SpiralMatrix(array2d, 5, 5);
PrintMatrix(spiralMatrix);
