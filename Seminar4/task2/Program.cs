/*
2. Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5
*/

// мое решение

int getCountNum(string msg, int num)
{
    int res = 0;
    for (int idx = 1; idx <= num; idx++)
    {
        
        num = num / 10;
        res++;
    }

     return res;
}


string msg = "Введите число: ";
Console.WriteLine(msg);
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(" -> ");
Console.Write(getCountNum(msg, num));
