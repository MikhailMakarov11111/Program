// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max < num2) max = num2;
if (max < num3) max = num3;
Console.WriteLine($"Максимальнео число {max}");
