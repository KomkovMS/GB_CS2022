/*
1. Задача 39: 

Напишите программу, которая перевернёт одномерный массив (последний элемент 
будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/

// мое решение

// метод, который генерирует размер массива 
int GetSizeArr(int min, int max)
{
    int size = new Random().Next(min, max);

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

// метод, который перевернёт одномерный массив
int[] getConvert(int[] arr, int sizeArr)
{
    int[] arr2 = new int[sizeArr];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[sizeArr - i - 1];
    }

    return arr2;
}


int sizeArr = GetSizeArr(1, 10);
int[] array = new int[sizeArr];
int[] newArray = FillArray(array, 1, 100);

int[] res = getConvert(newArray, sizeArr);

Console.WriteLine($"Размер массива: {sizeArr}\n"
                  + $"[{PrintArray(newArray)}] -> "
                  + $"[{PrintArray(res)}]");

Console.WriteLine("\n-------------------------------------------------------");

// решение на семинаре от преподавателя (без создания нового массива)
int[] arrNumbers = new int[5]{1, 2, 3, 4, 5};

int len = arrNumbers.Length;

for (int i = 0; i < len / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[len - i - 1];
    arr[len - i - 1] = temp;
}

for (int i = 0; i < len; i++)
{
    Console.WriteLine(arr[i]);
}







