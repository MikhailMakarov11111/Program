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

void PrintMatrix(int[,] matrix, int rows, int columns)
{
    int max = rows * columns;
    int count = 0;
    int count1 = 1;
    int count2 = 0;
    Console.Write($"{matrix[0, 0],5}");
    int i = 0;
    int j = 0;
    while (count != max)
    {
        while (i != count1)
        {
            while (j != matrix.GetLength(1) - count1)
            {
                ++j;
                Console.Write($"{matrix[i, j],5}");
                count++;
            }
            i++;
        }
        while (i != matrix.GetLength(0) - count1)
        {
            ++i;
            Console.Write($"{matrix[i, j],5}");
            count++;
        }
        while (j != count2)
        {
            --j;
            Console.Write($"{matrix[i, j],5}");
            count++;
        }
        while (i != count1)
        {
            --i;
            Console.Write($"{matrix[i, j],5}");
            count++;
        }
        count1++;
        count2++;
    }
}

int[,] array2d = CreateMatrixInt(4, 4);
PrintMatrix(array2d, 4, 4);
