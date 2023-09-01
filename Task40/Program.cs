// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsExistTriangle(int sid1, int sid2, int sid3)
{
    return sid1 < sid2 + sid3 && sid2 < sid1 + sid3 && sid3 < sid2 + sid1;
}

Console.WriteLine("Введите сторону 1");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону 2");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону 3");
int side3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(side1, side2, side3);
Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");