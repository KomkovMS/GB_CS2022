/*
4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
одновременно 7 и 23

Например,
14 -> нет 
46 -> нет 
161 -> да

*/

// мое решение

void getResult(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("-> да ");
    } else {
        Console.WriteLine("-> нет");
    }
}

void getRandomNum(int start, int end)
{
    int num = 161; // new Random().Next(start, end);
    Console.WriteLine("Рандомное число: " + num);


    getResult(num);
}


getRandomNum(1, 100);