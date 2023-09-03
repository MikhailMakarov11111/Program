// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum(int num)
{
    if (num < 0) num *= -1;
    int sum = num % 10;
    while (num > 1)
    {
        num /= 10;
        sum += num % 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNum(number);
Console.WriteLine($"Сумма чисел {number} ровна {result}");

