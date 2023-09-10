// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool NumberSearchMatrix(int[,] matrix, int lin, int col)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == lin-1 && j == col-1) return true;

        }
    }
    return false;
}

Console.WriteLine("Введите номер столбца");
Console.Write("Столбец №: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки");
Console.Write("Строка №: ");
int line = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
bool result = NumberSearchMatrix(array2d, column, line);
if (column < 0 || line < 0) Console.WriteLine("Введено некорректное значение");
else
{
    Console.WriteLine(result ? $"Число с координатами {line}, {column} -> {array2d[line-1,column-1]}" : "Такого эллемента в массиве нет");
}
