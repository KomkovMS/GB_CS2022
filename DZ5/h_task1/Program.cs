/*
1. Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

// метод, который генерирует размер массива 
int GetSizeArr()
{
    int size = new Random().Next(1, 10);

    return size;
}

// метод, который генерирует массив
int[] FillArray(int[] collection, int min, int max)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(min, max);
  }

  return collection;
}

// метод, который показывает сгенерированный массив
string PrintArray(int[] col)
{
    var str = string.Join(", ", col);

    return str;  
}

// метод, который показывает количество чётных чисел в массиве
int getAnEvenNumber(int[] arr)
{
    int result = 0;
    int j = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += j;
    }

    return result;
}


int sizeArr = GetSizeArr();
Console.WriteLine($"Размер массива: {sizeArr}");

int[] array = new int[sizeArr];

int[] newArray = FillArray(array, 100, 1000);

string NewStr = PrintArray(newArray);
Console.Write($"В массиве: [{NewStr}] колличество чётных чисел -> ");

int res = getAnEvenNumber(newArray);

Console.Write(res);

