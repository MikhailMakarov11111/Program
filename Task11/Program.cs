// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 999);
Console.WriteLine($"Случайное число {number}");
int Digit = Result(number);
Console.WriteLine($"Число без второй цифры {Digit}");

int Result(int num)
{
int firsDigit = num / 100; 
int lastDigit = num % 10;
int dableDigit = firsDigit * 10 + lastDigit;
return dableDigit;
}