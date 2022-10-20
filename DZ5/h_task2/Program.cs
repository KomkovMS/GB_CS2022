/*
2. Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

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

// метод, который показывает сумму элементов, стоящих на нечётных позициях
int getSunEvenNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }

    return sum;
}


int sizeArr = GetSizeArr();
Console.WriteLine($"Размер массива: {sizeArr}");

int[] array = new int[sizeArr];

int[] newArray = FillArray(array, -100, 100);

string NewStr = PrintArray(newArray);
Console.Write($"В массиве: [{NewStr}] сумма элементов, "
              + $"стоящих на нечётных позициях -> ");

int res = getSunEvenNumber(newArray);

Console.Write(res);


