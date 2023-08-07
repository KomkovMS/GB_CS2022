/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int GetAckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return GetAckermanFunc(m - 1, 1);
    else return GetAckermanFunc(m - 1, GetAckermanFunc(m, n - 1));
}

int m = 2, n = 3, mm = 3, nn = 2;

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {GetAckermanFunc(m, n)}");
Console.WriteLine($"m = {mm}, n = {nn} -> A(m,n) = {GetAckermanFunc(mm, nn)}");

