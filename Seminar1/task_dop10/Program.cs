/*
10. Показать вторую цифру трёхзначного числа
*/

void getNumTwo(int val)
{
    int result = val % 100 / 10;
    Console.WriteLine("Вторая цифра данного числа: " + result);
}


void getRandomNum(int start, int end)
{
    int val = new Random().Next(start, end);
    Console.WriteLine("Трехзначное число: " + val);
    getNumTwo(val);
}

getRandomNum(100, 999);