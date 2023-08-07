/*
Вывести значения от 1 до N при помощи рекурсии
*/

void Print(int s, int e)
{
    Console.Write(s + " ");
    if (s < e) Print(s + 1, e);
}

void Print2(int s, int e)
{
    Console.Write(e + " ");
    if (s < e) Print2(s, e - 1);
}

void Print3(int s, int e)
{
    if (s < e) Print3(s + 1, e);
    Console.Write(s + " ");
}


Print(1,10);
Console.WriteLine();
Print2(1,10);
Console.WriteLine();
Print3(1,10);