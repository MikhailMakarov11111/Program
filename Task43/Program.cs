// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)   
// k1 * x + b1 = k2 * x + b2
// k1 * x - (k2 * x) = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1)/(k1 - k2) x = (4 - 2)/(5 - 9)

Console.WriteLine("Введите переменные значения первого уравнения");
Console.Write("k1: ");
int numberK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1: ");
int numberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменные значения второго уравнения");
Console.Write("k2: ");
int numberK2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
int numberB2 = Convert.ToInt32(Console.ReadLine());

double countX = 0;
double countY = 0;

if (numberK1 == numberK2) Console.WriteLine("Прямые с введнными значениями парралельны");
else if (numberB1 == numberB2) Console.WriteLine("Прямые с введнными значениями совпадают");
else
{
    countX = (numberB2 - numberB1) / (numberK1 - numberK2);
    countY = numberK1 * countX + numberB1;
}
Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({countX:F1}; {countY:F2})");