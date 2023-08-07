/*
3. Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// метод, который генерирует размер массива 
int GetSizeArr()
{
    int size = new Random().Next(1, 10);

    return size;
}

// метод, который генерирует массив
double[] FillArray(double[] collection, int min, int max)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(min, max);
  }

  return collection;
}

// метод, который показывает сгенерированный массив
string PrintArray(double[] col)
{
    var str = string.Join(", ", col);

    return str;  
}

// метод, который находит разницу между макс и мин элементами массива
double getDifferenceMaxMinNum(double max, double min)
{
    double result = max - min;

    return result;
}

// метод, который находит макс и мин элементы массива
double getMaxMinNum(double[] arr)
{
    double max = arr[0];
    double min = max;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i + 1] > max) max = arr[i + 1];
        if (arr[i + 1] < min) min = arr[i + 1];
    }

    PrintMaxMin(max, min);
    return getDifferenceMaxMinNum(max, min);
}

// метод, который печатает максимальный и минимальный элементы массива
void PrintMaxMin(double max, double min)
{
    Console.WriteLine("Max: " + max + " min: " + min);
}


int sizeArr = GetSizeArr();
Console.WriteLine($"Размер массива: {sizeArr}");

double[] array = new double[sizeArr];

double[] newArray = FillArray(array, 1, 100);

string NewStr = PrintArray(newArray);

double res = getMaxMinNum(newArray);

Console.Write($"В массиве: [{NewStr}] разница между максимальным и минимальным "
              + $"элементом массива -> ");

Console.Write(res);


// решение преподавателя на семинаре

Console.WriteLine("\n----------------------------------");

int N = 10;
double[] arr = new double[N];
Random rand = new Random();
double diff = 0;

for (int i = 0; i < N; i++)
{
    arr[i] = rand.Next(-100, 100);
}

double max = arr[0], min = arr[0];
for (int i = 1; i < N; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

    if (arr[i] < min)
    {
        min = arr[i];
    }
}

diff = max - min;
Console.WriteLine(diff);