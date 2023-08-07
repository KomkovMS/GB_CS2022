/*
Задача 3** (задача повышенной сложности). Нарисовать блоксхему
Найти сумму элементов массива, лежащих между максимальным и
минимальным по значению элементами
*/


int[] arr = new int[] { 130, 12, 5, 1, 4, 16, 9};
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

int sum = 0;
if (idxMin < idxMax)
{
    for (int i = idxMin; i <= idxMax; i++)
    {
        sum += arr[i];
    }
}
else
{
    for (int i = idxMin; i >= idxMax; i--)
    {
        sum += arr[i];
    }
}



Console.WriteLine($"Sum = {sum}");

