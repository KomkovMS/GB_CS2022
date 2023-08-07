// 4. Упорядочивание данных в массиве (от максимального)

// мое решение

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод, который будет упорядочивать наш массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int tempory = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = tempory;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);