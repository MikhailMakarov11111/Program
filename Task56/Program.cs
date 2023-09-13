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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[] SumElemetsRowsMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

int MinElementArray(int[] array)
{
    int min = array[0];
    int index = 1;
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i + 1;
        }
    }
    return index;
}

int[,] array2d = CreateMatrixRndInt(5, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] sumElemetsRowsMatrix = SumElemetsRowsMatrix(array2d);
int result = MinElementArray(sumElemetsRowsMatrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result} строка");
