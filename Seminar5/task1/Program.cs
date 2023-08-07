/*
1. Задача 31: 
Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
элементов массива.

Например, 
в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.

*/

// мое решение

// метод, который генерирует массив
void FillArray(int[] collection, int min, int max)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(min, max);
  }
}

// метод, который суммирует отрицательные и положительные элементы массива
void GetSumMinusAndPlus(int[] col)
{
    int sumPlus = 0;
    int sumMinus = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < 0) {
            sumMinus += col[i];
        }
        else {
            sumPlus += col[i];
        }
    }
    PrintResult(col, sumPlus, sumMinus);
}

// метод, который печатает результат
void PrintResult(int[] Arr, int sumPlus, int sumMinus)
{
    var str = string.Join(", ", Arr);
    Console.WriteLine($"В массиве [{str}] сумма положительных чисел равна " 
                  + $"{sumPlus}, сумма отрицательных равна {sumMinus}.");
}
 

int[] array = new int[12];
FillArray(array, -9, 9);
GetSumMinusAndPlus(array);


// решение на семинаре  = от преподавателя
Console.WriteLine("\n------------------------");

int length = 12;
int[] newArr = new int[length];
Random rnd = new Random();
int positivesSum = 0;
int negativesSum = 0;

for (int i = 0; i < length; i++) {
    newArr[i] = rnd.Next(-10, 10);
    if (newArr[i] > 0) positivesSum += newArr[i];
    else if (newArr[i] < 0) negativesSum += newArr[i];
}

var str = string.Join(", ", newArr);

Console.WriteLine($"В массиве [{str}] "
                  + $"сумма положительных чисел равна {positivesSum}, "
                  + $"сумма отрицательных равна {negativesSum}");