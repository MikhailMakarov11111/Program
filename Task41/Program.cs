// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число");
        Console.Write("Число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int PositiveNumberArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите колличество чисел, которые вы желаеете ввести");
Console.Write("Колличество чиел: ");
int countNum = Convert.ToInt32(Console.ReadLine());
int[] createArrayInt = CreateArrayInt(countNum);
PrintArray(createArrayInt);
Console.WriteLine();
int result = PositiveNumberArray(createArrayInt);
Console.WriteLine($"Введено {result} чисел больше 0");


