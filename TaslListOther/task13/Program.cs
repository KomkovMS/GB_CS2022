/*
Найдите среднее арифметическое среди всех элементов массива
*/


double GetAverage (int[] arr) 
{
    double result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }
    result /= arr.Length; 

    return result;
}

void PrintResult(double average)
{
    Console.WriteLine($"Cреднее арифметическое среди всех элементов " +
                      $"массива: {average}");
}

int[] array = {3, 1, 5, 9, 4};
double average = GetAverage(array);
PrintResult(average);