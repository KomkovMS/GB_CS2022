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