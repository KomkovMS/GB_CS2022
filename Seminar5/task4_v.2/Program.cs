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

// метод генерации массива из 123 элементов случайными числами
void FillArray(int[] collection, int min, int max)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(min, max);
  }
}

// метод генерации массива из последовательных чисел в отрезке [10,99] 
int[] FillArr(int[] collection, int min, int max)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = min;
        min++;
    }

    return collection;
}

// метод сравнения элементов двух массивов на совпадение чисел двойным циклом
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

int[] array = new int[123];

FillArray(array, 1, 1000);

var strArray = string.Join(", ", array);

int[] Arr = new int[90];

int[] fillArr = FillArr(Arr, 10, 100);

var str = string.Join(", ", Arr);

int amountOfElem = FindElem(array, Arr);

Console.WriteLine($"[{strArray}] -> {amountOfElem}");