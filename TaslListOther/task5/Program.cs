/*
34. Написать программу замену элементов массива на противоположные
*/


int GetItem(int el)
{
    return Random.Shared.Next(-100, 100);
}

int[] GetItemAbs(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}


int[] arr = Enumerable.Range(1, 10)
            .Select(GetItem)
            .ToArray();
Console.WriteLine(String.Join(", ", arr));

int[] arrItemAbs = GetItemAbs(arr);
Console.WriteLine(String.Join(", ", arrItemAbs));

