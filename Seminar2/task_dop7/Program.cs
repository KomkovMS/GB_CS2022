/*
7. Показать числа от -N до N
*/

string getNumN(int n)
{
    int m = -n;
    string text = "";

    while (m <= n)
    {
        text = text + $" {m} ";
        m++;
    }
    return text;
}

string result = getNumN(5);
Console.WriteLine(result);

// Лекция 5 - хитрое решение от преподавателя
Console.WriteLine("\n-------------------------");

int af = - 5;
int uf = 5;
Console.WriteLine($" {af} . . {uf}");