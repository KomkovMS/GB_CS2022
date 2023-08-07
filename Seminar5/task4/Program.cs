/*
4. Задача 35: 
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

// мое решение 1

// метод, который генерирует массив
void FillArray(int[] collection, int min, int max)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(min, max);
  }
}

// метод, который находит количество элементов массива в заданном отрезке
int FindElements(int[] col)
{ 
    int result = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < 10 || col[i] >= 100) {
            result += 0;
        } else {
            result++;
        }
    }

    return result;
}

int[] array = new int[123];
FillArray(array, 1, 1000);
int amountOfElements = FindElements(array);
var strArray = string.Join(", ", array);
Console.WriteLine($"[{strArray}] -> {amountOfElements}");
