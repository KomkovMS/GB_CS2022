/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.

45 -> 101101
3  -> 11
2  -> 10

*/

// мое решение

// метод, который возвращает строку с неперевернутым двоичным числом
string GetStr(int a, int n)
{
    int quot = 0;
    string result = String.Empty;
    while (a > 0)                     
    {
        quot = a / n;                    
        result += a % n;                 
        a = quot;                                  
    }
    return result;
}

// метод, который переворачивает строку с двоичным числом
string GetBinarySystem(string str)
{
    int l = str.Length;
    string newStr = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        newStr += str[l - i - 1];
    }

    return newStr;
}

int a = 45;
int n = 2;
string binarySystem = GetStr(a, n);
Console.WriteLine($"{a} -> {GetBinarySystem(binarySystem)}");
a = 3;
binarySystem = GetStr(a, n);
Console.WriteLine($"{a} -> {GetBinarySystem(binarySystem)}");
a = 2;
binarySystem = GetStr(a, n);
Console.WriteLine($"{a} -> {GetBinarySystem(binarySystem)}");

// ЛОГИКА
// while (a >= 1)                        //  29>=  1       14>=    1       7 >=    1       3>=    1        1 >=    1          0 >= 1 false
// {
//     quot = a / n;                     // 29/2=  14      14/2=   7       7/2=    3       3/2=   1        1/2=    0
//     result = a % n;                   // 29%2=  1       14%2=   0       7%2=    1       3%2=   1        1%2=    1
//     // Console.Write(result + " ");   //        1               1 0             1 0 1          1 0 1 1          1 0 1 1 1
//     a = quot;                         //        14              7               3              1                0         
// }


