/*
Задача - найти второе максимальное число
*/

int[] arr = new int[] { 100, 115, 23, 3, 24, 5, 610, 7};
int len = arr.Length;
int max = arr[0];
int maxTwo = arr[0];

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len; j++)
    {
        if (arr[j] > max) max = arr[j];
        else if (arr[j] > maxTwo && arr[j] < max) maxTwo = arr[j];
    }
}

Console.WriteLine(max);
Console.WriteLine(maxTwo);