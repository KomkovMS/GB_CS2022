/*
Задача 4*. Нарисовать блок-схему
Найти среднее арифметическое среди всех элементов массива.
*/

int GetSumArray(int[] arr, int len)
{
    int sum = 0;

    for (int i = 0; i < len; i++)
    {
        sum += arr[i];
    }

    return sum;
}

double GetAverage(double sumArr, int len)
{
    double result = 0;
    result = sumArr / len;

    return result;
}

void PrintResult(int[] arr, double result)
{
    Console.WriteLine($"среднее арифметическое среди элементов массива" +
                      $"[{string.Join(",", arr)}] = {Math.Round(result, 2)}");
}


int[] arr = new int[] { 10, 1, 22, 3, 14, 5 };
int len = arr.Length;

int sumArr = GetSumArray(arr, len);
double average = GetAverage(sumArr, len);
PrintResult(arr, average);
