// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num*=-1;

int ThreeDigit(int numb)
{
    while (numb > 999)
    {
         numb = numb/10;
    }
    return numb;
}

if (num < 100) Console.WriteLine($"У числа {num} -> третьей цифры нет");
else
{
    int threeDigit = ThreeDigit(num)%10;
    Console.WriteLine($"У числа {num} -> третьея цифра {threeDigit}");
}