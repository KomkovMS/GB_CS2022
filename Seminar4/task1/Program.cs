/*
1. Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт 
сумму чисел от 1 до А.

7 -> 28
4 -> 10
8 -> 36
*/

// мое решение

int getSum(string msg, int num)
{
    int sum = 0;
    for (int idx = 1; idx <= num; idx++)
    {
        sum += idx; 
    }

    return sum;
}


string msg = "Введите число: ";
Console.WriteLine(msg);
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(" -> ");
Console.Write(getSum(msg, num));

// решение на семинаре (преподавателя)

// аналогичное