// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int n = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product[i, j] += matrix1[i, k] * matrix2[n++, j];
            }
        }
    }
    return product;
}


int[,] array2dOne = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2dOne);
Console.WriteLine();
int[,] array2dTwo = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2dTwo);
Console.WriteLine();
if (array2dOne.GetLength(1) == array2dTwo.GetLength(0))
{
    int[,] multiplicationMatrix = MultiplicationMatrix(array2dOne, array2dTwo);
    PrintMatrix(multiplicationMatrix);
}
else
{
    Console.WriteLine("Умножение данных матриц невозможно");
}
