// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99 + 1
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {number}");

// int firsDigit = number / 10; // 78 / 10 = 7,9 = 7
// int secondDigit = number % 10;

// if (firsDigit > secondDigit) Console.WriteLine($"Наибольшее цифра числа -> {firsDigit}");
// else Console.WriteLine($"Наибольшее цифра числа -> {secondDigit}");

// int maxDigit = firsDigit >secondDigit ? firsDigit : secondDigit;
// Console.WriteLine($"Наибольшее цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшее цифра числа -> {maxDigit}");

int MaxDigit(int num) // num = number
{
    int firsDigit = num / 10;
    int secondDigit = num % 10;
    // if (firsDigit > secondDigit) return firsDigit;
    // return 0;
    int result = firsDigit >secondDigit ? firsDigit : secondDigit;
    return result;
}