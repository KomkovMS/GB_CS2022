/*
3. Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.

4 -> 24 
5 -> 120
*/

// мое решение

int getmult(string msg, int num)
{
    int mult = 1;
    for (int idx = 1; idx <= num; idx++)
    {
        mult *= idx; 
    }

    return mult;
}


string msg = "Введите число: ";
Console.WriteLine(msg);
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(" -> ");
Console.Write(getmult(msg, num));

// решение на семинаре (аналогичное)