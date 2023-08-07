/*
Записать алгоритм, который "перенесет" самое большое значение элемента
в правый край массива
*/


int GetMaxArr (int[] arr) 
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    
    return max;
}

int[] GetMaxArrItemRight (int[] arr, int max) 
{
    int l = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == max)
        {
            arr[i] = arr[l - 1];
            arr[l - 1] = max;
        }
    }
     

    return arr;
}

void PrintResult(int[] arr)
{
    Console.WriteLine($"В массиве: [3, 9, 5, 1, 4] " +
                      $"Максимальный элемент {arr[arr.Length - 1]}");
    
    Console.Write($"Если его перенести в конец, то получиться массив: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($"]");
}


int[] array = {3, 9, 5, 1, 4};
int maxArr = GetMaxArr(array);
int[] maxArrItemRight = GetMaxArrItemRight(array, maxArr);
PrintResult(maxArrItemRight);