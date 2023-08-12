// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int Result(int numb)
{
int firsDigit = numb / 100; 
int lastDigit = numb % 10;
int dableDigit = (numb - firsDigit * 100 - lastDigit)/10;
return dableDigit;
}

if (num > 999 || num < 100)
{
    Console.WriteLine("Введено некоректное значение");
}
else
{
    int Digit = Result(num);
    Console.WriteLine($"Вторая цифра числа {num} --> {Digit}");
}
