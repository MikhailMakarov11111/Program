// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int num)
{
     if (num / 10000 == num % 10 || (num / 1000) % 10 == (num / 100) % 10) Console.WriteLine($"Число {num} является палиндромом");
     else Console.WriteLine($"Число {num} не является палиндромом");
}

Console.WriteLine("Введите пятизначное число");
Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * -1;
if (number < 10000 || number > 99999) Console.WriteLine("Введено некорректно значение");
else Palindrome(number);


