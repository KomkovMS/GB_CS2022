/*
6. Выяснить является ли число чётным
*/


void getNum(int val)
{
    if (val % 2 == 0)
    {
        Console.WriteLine("Число " + val + " - четное ");
    }
    else
    {
        Console.WriteLine("Число " + val + " - НЕчетное ");
    }
}

void getRandomNum(int start, int end)
{
    int val = new Random().Next(start, end);
    Console.WriteLine("Дано число: " + val);
    getNum(val);
}

getRandomNum(1, 100);

