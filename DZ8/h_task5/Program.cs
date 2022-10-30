/*

Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7

*/

ulong n = 50;
ulong m = 0;
void PrintArrayGroup(ulong[,] arr)
{
    for (ulong i = 0; i < Convert.ToUInt64(arr.GetLength(0)); i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (ulong j = 0; j < Convert.ToUInt64(arr.GetLength(1)); j++)
        {
            if (arr[i, j] > 0) Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
ulong countGroup(ulong x)
{
    if (x == 0) return m;
    m++;
    return countGroup(x / 2);
}
m = countGroup(n);
Console.WriteLine($"Для числа {n} групп {m}");
ulong[,] numberGroup = new ulong[m, n];
for (ulong i = 1; i <= n; i++)
{
    bool exit = false;
    for (ulong j = 0; j < m; j++)
    {
        for (ulong k = 0; k < i; k++)
        {
            if (numberGroup[j, k] > 0 && i % numberGroup[j, k] == 0)
            {
                //Console.WriteLine("Проверка1 " + "j " + j + " k " + k + " i " + i + " " + exit);
                break;
            }
            if (numberGroup[j, k] == 0)
            {
                numberGroup[j, k] = i;
                exit = true;
                //Console.WriteLine("Проверка2 " + "j " + j + " k " + k + " i " + i + " " + exit);
                break;
            }
        }
        if (exit == true) break;
    }
}
PrintArrayGroup(numberGroup);