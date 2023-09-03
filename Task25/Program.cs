// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeNum(int num1, int num2)
{
    if (num2 == 0) return 1;
    int comp = 1;
    for (int i = 1; i <= num2; i++)
    {
        comp = comp * num1;
    }
    return comp;
}

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 больше или равное 0");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0) Console.WriteLine("Введено некоректное значение");
else
{
    int degreeNum = DegreeNum(number1, number2);
    Console.WriteLine($"{number1} в степени {number2} -> {degreeNum}");
}
