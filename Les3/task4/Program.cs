// Работа с массивами

// 4. Упорядочивание данных в массиве

// Алгоритм сортировки (выбор)

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
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
        }

        int tempory = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempory;

        }
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);