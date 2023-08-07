/*
Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.

453 -> 12
45 -> 9
*/

// решение без рекурсии
int digitsSum(int A) {
    Console.Write($"{A} -> ");
    int summ = 0;
    while (A != 0) {
        summ += A % 10;
        A = A / 10;
    }

    Console.Write($"{summ}");

    return summ;
}

int summ = digitsSum(453);

// решение преподавателя на семинаре с рекурсией
Console.WriteLine("\n------------------------------");


int SumNumbers(int num)
{
    if (num == 0) return 0;
    return (num % 10 + SumNumbers(num / 10));
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> {SumNumbers(number)}");