// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticMeanRowsMatrix(int[,] matrix)
{
    double[] arithcMeanRows = new double[matrix.GetLength(1)];
    double sum = 0;
    double sumArithcMeanRows = 0;
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        sumArithcMeanRows = sum/matrix.GetLength(0);
        arithcMeanRows[k++] = sumArithcMeanRows;
        sum = 0;
    }
    return arithcMeanRows;
}

void PrintArray(double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
else Console.Write($"{arr[i]:F1}");
}
Console.WriteLine("]");
}

int[,] array2d = CreateMatrixRndInt(5, 6, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
double[] arithmeticMeanRowsMatrix = ArithmeticMeanRowsMatrix(array2d);
PrintArray(arithmeticMeanRowsMatrix);