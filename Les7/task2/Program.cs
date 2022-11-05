/*
Собрать строку с числами от a до b, a ≥ b
*/

string NumbersFor(int a, int b) {    
    string result = String.Empty;    
    for (int i = b; i >= a; i--)    
    {        
        result += $"{i} ";    
    }    
    return result; 
} 

string NumbersRec(int a, int b) 
{    
    if (a >= b) return $"{a} " + NumbersRec(a - 1, b);    
    else return String.Empty; 
} 

string NumbersRec1(int a, int b) 
{    
    if (a <= b) return NumbersRec1(a + 1, b) + $"{a} ";    
    else return String.Empty; 
} 

Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1 
Console.WriteLine(NumbersRec(10, 1)); // 10 9 8 7 6 5 4 3 2 1 
Console.WriteLine(NumbersRec1(1, 10));// 10 9 8 7 6 5 4 3 2 1
