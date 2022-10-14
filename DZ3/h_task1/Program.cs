/*
1. Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/


// Вариант 1

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


// Решение преподавателя на Семинаре 4 (вар.1)

bool isPalindrome(int x) {                        // 11211
    int div = 1;                                  // 1
    while (x / div >= 10) {                       // 11211 / 100000 >= 10
        div *= 10;                                // 100000 * 10 = 1000000
    }
    Console.WriteLine(div);
    while (x != 0) {                              // 11211                  
        int l = x / div;                          // 11211 / 100000 = 0
        int r = x % 10;                           // 11211 % 10 = 1
        if (l != r) {                              // 0 != 1
            Console.WriteLine("Not Lalindrome");   // Not Lalindrome
            return false;
        }

        x = (x % div) / 10;                 
        div /= 100;
    }
    Console.WriteLine("Palindrom");
    return true;
}

// Решение преподавателя на Семинаре 4 (вар.2)

bool isPalindromeLight(int[] arr) {
    bool result = false;
    const N = arr.Lenght;
    for (int i = 0; i < N / 2; i++) {
        if (arr[i] != arr[N - i - 1]) {
            Console.WriteLine("Not Polindrom");
            return result;
        }
    }
    result = true;
    Console.WriteLine("Polindrom");

    return result;
}

isPalindrome(1231);
isPalindrome(11211);
isPalindrome(1221);


int[] arr = Array.ConvertAll(Console.ReadLine().Split(''), int.Parse);
isPalindromeLight(arr);