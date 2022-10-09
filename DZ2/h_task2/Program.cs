/*
2.  Напишите метод, который выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

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