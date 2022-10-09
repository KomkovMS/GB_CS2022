/*
1. Напишите метод, который принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

void getNumTwo(int num)
{
    int numTwo = (num % 100) / 10;
    Console.WriteLine("Вторая цифра трехзначного числа: " + numTwo);
}

void getRandomNum(int start, int end)
{
    int num = new Random().Next(start, end);
    Console.WriteLine("Рандомное трехзначное число: " + num);


    getNumTwo(num);
}


getRandomNum(100, 999);

