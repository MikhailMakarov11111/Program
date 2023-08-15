// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
string num = Console.ReadLine();

string DayWeek(string numb)
{
    if (numb == "1")
        return numb = "Понедельник";
    if (numb == "2")
        return numb = "Вторник";
    if (numb == "3")
        return numb = "Среда";
    if (numb == "4")
        return numb = "Четверг";
    if (numb == "5")
        return numb = "Пятница";
    if (numb == "6")
        return numb = "Суббота";
    if (numb == "7")
        return numb = "Воскресенье";
    else
        return num = "Некорректное значение";
};

string Weekend(string number)
{
    if (number == "6" || number == "7")
        return number = "выходной";
    else
    {
        return number = "не выходной";
    }
}
if (num == "1" || num == "2" || num == "3" || num == "4" || num == "5" || num == "6" || num == "7")
{
    string dayWeek = DayWeek(num);
    string weekend = Weekend(num);
    Console.WriteLine($"{dayWeek} -> {weekend}");
}
else Console.WriteLine("Введено некорректное значение");