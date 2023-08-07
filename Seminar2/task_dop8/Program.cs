/*
8. Показать четные числа от 1 до N
*/

// мое решение
void getRandomNum(int start, int end)
{
    int num = new Random().Next(start, end);
    Console.WriteLine("Рандомное число N: " + num);

    getNum(num);
}

void getNum(int num)
{
    Console.Write($"Четные числа от числа {num}: ");
    for (int i = 0; i <= num; i++)
    {
        if (i % 2 == 0)
        Console.Write(i + " ");
    }
}


getRandomNum(1, 10);
