/*
Задача 1. Нарисовать блок-схему
Нахождение индексов максимального и минимального элемента
массива
*/


// Вариант 2

int[] arr = new int[]{41, -52, 1, 3, 0, -19, 333, 2, 1};
int len = arr.Length;
int idxMax = 0;
int idxMin = 0;
int max = arr[idxMax];
int min = arr[idxMin];

for (int i = 1; i < len; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
        idxMin = i;
    }
    
    else if (arr[i] > max)
    {
        max = arr[i];
        idxMax = i;
    }
}

Console.WriteLine($"Max = {max}, IdxMax = {idxMax}");
Console.WriteLine($"Min = {min}, IdxMin = {idxMin}");