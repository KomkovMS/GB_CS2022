/*
2. Даны два числа. Показать большее и меньшее число
*/

void getNaxValue(int val1, int val2)
{
    int maxVal = val1;
    if (val2 > maxVal)
    {
        maxVal = val2;
    }
    Console.WriteLine("Max value: " + maxVal);
}

void getRandomNum(int start, int end)
{
    int val1 = new Random().Next(start, end);
    Console.WriteLine("Первое число: " + val1);
    int val2 = new Random().Next(start, end);
    Console.WriteLine("Второе число: " + val2);
    getNaxValue(val1, val2);
}

getRandomNum(-100, 100);

