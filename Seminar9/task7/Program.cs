/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

*/

// мое решение

Console.Write("Введите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString();
    // Рекурсивный случай 
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.Write($"M = {M}; N = {N} -> {PrintNumbers(M, N)}");

// решение преподавателя на семинаре (аналогичное)