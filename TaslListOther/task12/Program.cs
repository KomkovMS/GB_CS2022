/*
Найти сумму всех нечётных элементов массива
*/

int GetSumOddElement(int[] arr) 
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) result += arr[i];
    }

    return result;
}

void PrintResult(int sum)
{
    Console.WriteLine($"Cумма всех нечётных элементов массива: {sum}");
}


int[] array = {-12, 10, -11, 3, 25};

int sumOddElement = GetSumOddElement(array);

PrintResult(sumOddElement);