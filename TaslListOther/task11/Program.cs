/*
Задача - посчитать количество положительных чисел в произвольно заданном массиве
*/

int getSumOfPositiveNumbers(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result += arr[i];
    }

    return result;
}

void PrintResult(int sum)
{
    Console.WriteLine($"Кол-во положительных чисел: {sum}");
}


int[] array = {-2, 0, -1, 3, 2};

int sum = getSumOfPositiveNumbers(array);

PrintResult(sum);