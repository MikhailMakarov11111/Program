﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число от 2 и более");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num<2) Console.WriteLine("введено не корректное значение");

while (count <= num)
{
     Console.Write($"{count} ");
     count = count+2;
}
