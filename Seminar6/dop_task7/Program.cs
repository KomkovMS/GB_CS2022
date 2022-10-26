/*
Определение производительности при переборе двумерного массива
*/
Console.Clear();

int n = 8000;
int[,] m = new int[n, n];
int s = 0;

// time start
DateTime ts = DateTime.Now;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        s += m[i, j];
    }
}
DateTime te = DateTime.Now;
System.Console.WriteLine((te-ts).TotalMilliseconds);
