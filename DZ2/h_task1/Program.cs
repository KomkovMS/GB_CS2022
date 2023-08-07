/*
1. Напишите метод, который принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

// мое решение
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

// пример решения другого ученика на семинаре 3

Console.WriteLine("Задача №10");
Console.WriteLine("----------------------------------------");

int number, number2;

number = new Random().Next(100, 999);
Console.WriteLine("Исходное число: " + number);

number2 = (number/10) % 10;
Console.WriteLine("Итоговое число: " + number2);

