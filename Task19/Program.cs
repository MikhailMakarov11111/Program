// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int num)
{
    return (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10);
}

Console.WriteLine("Введите пятизначное число");
Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * -1;
if (number < 10000 || number > 99999) Console.WriteLine("Введено некорректно значение");
else
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? $"Число {number} является палиндромом" : $"Число {number} не является палиндромом");
}

// if ((number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10))
// {
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");


