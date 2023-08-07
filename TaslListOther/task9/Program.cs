/*
Найти максимальное значение 5 элементов при помощи массива
*/


int GetMaxNumber(int size, int[] arr)
{
    int max = arr[0];

    for (int i = 1; i < size; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    
    return max;
}

void PrintResult(int[] arr, int max)
{
    Console.WriteLine($"В массиве [{arr}] максимальное значение = {max}");
}


int[] array = new int[5]{11, 21, 3, 14, 81};
int l = array.Length;

int maxNumber = GetMaxNumber(l, array);
PrintResult(array, maxNumber);
