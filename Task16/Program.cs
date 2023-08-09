// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

bool WiltTwoNum(int numb1, int numb2)
{
    return numb1 / numb2 == numb2 || numb2 / numb1 == numb1;
}

bool result = WiltTwoNum(num1,num2);
Console.WriteLine(result ? "Да" : "Нет");