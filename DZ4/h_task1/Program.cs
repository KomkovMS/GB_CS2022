/*
1) Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/


int NumPow(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    
    return result;
}


void EnterNum(string msg)
{
    Console.Write(msg);
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write(msg);
    int num2 = Convert.ToInt32(Console.ReadLine());

    PrintNum(num1, num2);
}

void PrintNum(int num1, int num2)
{
    Console.Write("-> ");
    Console.Write(NumPow(num1, num2));
}

EnterNum("Enter number: ");

