// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = count;
            count++;
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int count = 0;
    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    
    if (count )

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
    }
}

int[,] array2d = CreateMatrixInt(4, 4);
PrintMatrix(array2d);
