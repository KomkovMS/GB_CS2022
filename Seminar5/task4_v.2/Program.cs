/*
4. Задача 35: 
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

// мое решение 2
Console.WriteLine("\n------------------------------");

int[] FillArr(int[] collection, int min, int max)
{
    int[] newArray = collection;

    for (int index = min; index < max; index++)
    {
        newArray[index] += 1;
    }

    return newArray;
}

int FindElem(int[] col, int[] collection)
{
    int result = 0;
    for (int i = 0; i < col.Length; i++)
    {
        for (int j = 0; j < collection.Length; j++)
        {
            if (collection[j] == col[i])
            {
                result++;
            }
        }
    }

    return result;
}


int[] Arr = new int[90];
int[] fillArr = FillArr(Arr, 10, 100);
Console.WriteLine(fillArr);
// Console.WriteLine();
// int amountOfElem = FindElem(newArray, Arr);
// Console.WriteLine($"[{strArray}] -> {amountOfElem}");