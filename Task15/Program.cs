// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели (пн - 1, вт - 2, ..., вс - 7): ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Данный день недели выходной?");
if (day == 6 ^ day == 7)
    {
        Console.WriteLine("Да");
    } 
if (day > 0 & day < 6)
    {
        Console.WriteLine("Нет");
    }
if (day < 1 ^ day > 7)
    {
        Console.WriteLine("Неверные данные! (пн - 1, вт - 2, ..., вс - 7)");
    }
