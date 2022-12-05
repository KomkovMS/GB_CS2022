/*
Задача 1. Нарисовать блок-схему
Нахождение индексов максимального и минимального элемента
массива
*/

int[] arr = new int[]{41, 52, 1, 3, 0, -19, 3, 2, 1};
int len = arr.Length;
int idxMax = 0;
int idxMin = 1;
int max = arr[idxMax];
int min = arr[idxMin];


for (int i = 0; i < len; i++)
{
    if (arr[i] > max) 
    {
        max = arr[i];
        idxMax = i;
    }

    for (int j = 0; j < len; j++)
    {
        if (arr[j] < min) 
        {
            min = arr[j];
            idxMin = j;
        }
    }
}

Console.WriteLine($"Max = {max}, IdxMax = {idxMax}");
Console.WriteLine($"Min = {min}, IdxMin = {idxMin}");

