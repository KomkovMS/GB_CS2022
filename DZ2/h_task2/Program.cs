/*
2.  Напишите метод, который выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

// мое решение

void getNumThree(int num)
{
    if (num > 10000)
    {
        int numThree = (num % 1000) / 100;
        Console.Write(" -> " + numThree);
    }
    else if (num > 1000 & num < 10000)
    {
        int numThree = (num % 100) / 10;
        Console.Write(" -> " + numThree);
    }
    else if (num > 100 & num < 1000)
    {
        int numThree = num % 10;
        Console.Write(" -> " + numThree);
    }
    else
    {
        Console.Write(" третьей цифры нет");
    }
    
}

void getRandomNum(int start, int end)
{
    int num = new Random().Next(start, end);
    Console.Write("Рандомное число: " + num);


    getNumThree(num);
}


getRandomNum(1, 99999);

// Решение преподавателя на семинаре 3
Console.WriteLine("\n------------------------------");

void hasThirdNumber(int x) {
    int div = 1;
    while (x / div >= 10) {
        div *= 10;
    }

    if (div < 100) {
        Console.Write("\nToo little number");
    } 
    else {
        // last number of x / (div / 100)    123456
        int digit = (x / (div/100)) % 10;
        Console.WriteLine("Third is {0}", digit);
    }
}

hasThirdNumber(12);
hasThirdNumber(123);
hasThirdNumber(1234);
hasThirdNumber(12345);
hasThirdNumber(123456);
hasThirdNumber(975431982);