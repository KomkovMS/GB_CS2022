/*
2. Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/


int NumSun(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }

    return sum;
}

void EnterNum(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());

    PrintNum(num);
}

void PrintNum(int num)
{
    Console.Write("-> ");
    Console.Write(NumSun(num));
}


EnterNum("Enter the number: ");


// решение на семинаре 5 от преподавателя
Console.Write("\n------------------------");

int digitsSum(int A) {
    int summ = 0;
    while (A != 0) {
        summ += A % 10;
        A = A / 10;
    }

    Console.Write("\n" + summ);

    return summ;
}

int summ = digitsSum(452);
digitsSum(17);
digitsSum(171);