// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int remaider = Remaider(num1,num2);
if (remaider == 0)
{
    Console.WriteLine(" " + num1 + " кратно " + num2 + "");
}
else
{
    Console.WriteLine($"{num1} не кратно {num2}, остаток от деления: {remaider}");
}

int Remaider(int numb1, int numb2)
{
    return numb1 % numb2;
}