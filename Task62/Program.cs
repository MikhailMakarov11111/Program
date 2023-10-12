// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int max = rows * columns;
    int count1 = 1;
    int count2 = 0;
    int number = 0;
    int i = 0;
    int j = 0;
    while (number != max)
    {
        while (j != matrix.GetLength(1) - count1)
        {
            number++;
            if (number > max) return matrix;
            matrix[i, j] = number;
            j++; 
        }
        while (i != matrix.GetLength(0) - count1)
        {
            number++;
            if (number > max) return matrix;
            matrix[i, j] = number;
            i++;
        }
        while (j != count2)
        {
            number++;
            if (number > max) return matrix;
            matrix[i, j] = number;
            j--;
        }
        while (i != count1)
        {
            number++;
            if (number > max) return matrix;
            matrix[i, j] = number;
            i--;
        }
        count1++;
        count2++;
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

int[,] spiralMatrix = SpiralMatrix(4, 4);
PrintMatrix(spiralMatrix);
