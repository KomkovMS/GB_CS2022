/*

Сколько маршрутов существует, используя команды +1 и *3, чтобы превратить 
число 23 в 2022

(задача на рекурсию )
см. пример

        |0, i < 2
        /1, если i = 2
f(i) = { f(i/2) + f(i-1), если i - четное
        \f(i-1), если i - нечетное


*/

long f(long s, long e)
{
    if (e == s) return 1;
    if (e < s) return 0;

    else if (e % 3 == 0) return f(s, e / 3) + f(s, e - 1);

    else return f(s, e - 1);
}

Console.WriteLine($"f(2,11): {f(23,2022)}");


// решение на семинаре от другого ученика
Console.WriteLine("\n------------------------");


int Reduction(int e, int s)
{
    if (e == s) return 1;
    else if (e < 2022) return Reduction(e + 1, s) + Reduction(e * 3, s);
    else return 0;
}

int res = Reduction(23, 2022);
Console.WriteLine(res);