/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

*/

// мое решение циклом без рекурсии
int n = 6;

Console.Write($"{n} -> ");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i}, ");
}


// решение преподавателя на семинаре
Console.WriteLine();

Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString();
    // Рекурсивный случай 
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.Write($"{N} -> ");
Console.Write($"{PrintNumbers(1, N)}");