// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ComNumbers(int num)
{
    if (num == 0) return 0;
    int com = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            com *= i; // com = com * i;
        }

    }
    return com;
}

Console.WriteLine("Введите натруальное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) Console.WriteLine("Некорректный ввод");
else
{
    int comNumbers = ComNumbers(number);
    Console.WriteLine($"{number} -> {comNumbers}");
}
