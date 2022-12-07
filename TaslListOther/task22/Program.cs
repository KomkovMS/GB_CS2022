/*
Задача - найти второе максимальное число (через индексы)
*/

int[] arr = new int[] { 11100, 1150, 23, 32354, 24, 5, 610, 7};
int len = arr.Length;
int max = 0;
int idxOne = 0;
int maxTwo = 0;
int idxTwo = 0;

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len; j++)
    {
        if (arr[j] > max) 
        {
            max = arr[j];
            idxOne = j;
        }
        else if (arr[j] > maxTwo && j != idxOne)
        {
            maxTwo = arr[j];
            idxTwo = j;
        }
    }
}

Console.WriteLine($"maxOne = {max}, maxTwo = {maxTwo}");