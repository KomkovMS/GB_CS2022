/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

// мое решение рекурсией

int Get(int A, int B)
{
    int count = 0;
    if (B == count) return 1;
    return (A * Get(A, (B - 1)));
}

int A = 2;
int B = 3;

int result = Get(A, B);
Console.WriteLine($"A = {A}; B = {B} -> {result} ({A} в {B}-й степени)");


// решение преподавателя на семинаре
int number = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());

int Power(int num, int pow)
{
    // Базовый случай
    if (pow == 1) return num;
    // Рекурсивный случай
    return (num * Power(num, pow - 1));
}

Console.WriteLine(Power(number, power));
