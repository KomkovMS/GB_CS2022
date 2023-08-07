/*
Задача - Подсчитать количество положительных чисел  в произвольно заданном 
массиве
[-2, 8, 14, -34, -9 , 7, 7, 4] 
*/

int[] arr = new int[]{-2, 8, 14, -34, -9 , 7, 7, 4};
int len = arr.Length;
int sumPlus = 0;

for (int i = 0; i < len; i++)
{
    if (arr[i] > 0) sumPlus += arr[i];
}

Console.WriteLine($"Сумма положительных чисел в массиве: [{string.Join(", ", arr)}] равна: {sumPlus}");