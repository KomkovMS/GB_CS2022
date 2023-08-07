/*
21. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом*.

14212 -> нет
12821 -> да
23432 -> да

* число, буквосочетание, слово или текст, одинаково читающееся 
в обоих направлениях

*/


// мое решение

void MyCheck(int num)
{
    int firstNum = num / 10000;
    int twoNum = num % 10000 / 1000;
    int fourNum = num % 100 / 10;
    int fiveNum = num % 10;
    getCneckNum(firstNum, twoNum, fourNum, fiveNum, num);
}

void getCneckNum(int firstNum, int twoNum, int fourNum, int fiveNum, int num)
{
    if (firstNum == fiveNum & twoNum == fourNum)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ является палиндромом");
    }
}
    

void getNum(string text)
{
    while (true)
    {
        Console.WriteLine(text);
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 10000 & num <= 99999)
        {
            MyCheck(num);
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели НЕпятизначное число");
        }
    } 
}

getNum("Введите пятизначное число для проверки на палиндром: ");


// решение на семинаре
// Console.WriteLine("-------------------------------------------");

// int n = 12321;
// int value = n;

// int result = 0;
// while (value != 0)
// {
//     int o = value % 10;
//     // result *= 10 + o;
//     // value /= 10;
//     Console.WriteLine(o);
// }

// Console.WriteLine(result == n);


