/*
1. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/

// мое решение
int num = new Random().Next(10, 99);
Console.WriteLine("Рандомное число: " + num);

int firstNum = num / 10;
Console.WriteLine("Первое число: " + firstNum);

int lastNum = num % 10;
Console.WriteLine("Последнее число: " + lastNum);

int MaxNum = lastNum;
if (firstNum > MaxNum)
{
    MaxNum = firstNum;
}

Console.WriteLine("Наибольшая цифра числа " + num + " равна "  + MaxNum);

// на семинаре (офрмление функцией)

void getMaxNum(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine(num1 + " больше чем " + num2);
    }
    else
    {
        Console.WriteLine(num2 + " больше чем " + num1);
    }
}


void getRandomNum(int start, int end)
{
    int numbers = new Random().Next(start, end);
    Console.WriteLine(numbers);
    int secondNum = numbers % 10;
    int firstNum = numbers / 10;
    getMaxNum(firstNum, secondNum);
}


getRandomNum(10, 99);