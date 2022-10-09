/*
2. Напишите программу, которая выводит случайное трёхзначное число и удаляет 
вторую цифру этого числа.
Например,
456 -> 46
782 -> 72
918 -> 98
*/

// мое решение

void getDelTwoNumber(int num)
{
    int firstNum = num / 100;
    Console.Write("-> " + firstNum);    // так ок, но получаем строку
    int lastNum = num % 10;
    Console.Write(lastNum + "\n или \n");
    int numTwoDel = firstNum * 10 + lastNum; // так получаем число
    Console.Write("-> " + numTwoDel);
}

void getRandomNum(int start, int end)
{
    int num = new Random().Next(start, end);
    Console.WriteLine("Рандомное трехзначное число: " + num);

    int numTwo = (num % 100) / 10;
    Console.WriteLine("Среднее число трехзначного числа: " + numTwo + "\n");

    getDelTwoNumber(num);
}


getRandomNum(100, 999);

// решение на семинаре

int something(int start, int finish)
{
    int numberA = new Random().Next(start, finish);
    Console.WriteLine("\n" + numberA);
    int thirdnumber = numberA % 10;
    int firstnumber = numberA / 100;
    int result = firstnumber * 10 + thirdnumber;
    return result;
}

int A = something(100, 999);
Console.WriteLine(A);