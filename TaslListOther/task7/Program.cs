/* 
Найти сумму всех четных чисел от 1 до 15
*/



int getSumOfEvenNumbers(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0) result += i; // 2 + 4 + 6 + 8 + 10 + 12 + 14 = 56
    }

    return result;
}

int numMax = 15;
int sum = getSumOfEvenNumbers(numMax);

Console.WriteLine($"Сумма всех четных чисел числа {numMax} равна {sum}");
