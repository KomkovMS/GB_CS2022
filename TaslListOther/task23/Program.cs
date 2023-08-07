/*
Задача - найти второе максимальное число (по блок-схеме на лекции)
*/

int[] arr = new int[] { 1, 8, 3, 2, 6 };
int len = arr.Length;
int firstMax = arr[0];
int secondMax = arr[0];
int currentIndex = 2;

if (arr[1] > firstMax) firstMax = arr[1];
else secondMax = arr[1];

while (currentIndex < len)
{
    if (arr[currentIndex] > firstMax)
    {
        secondMax = firstMax;
        firstMax = arr[currentIndex];
    }
    else if (arr[currentIndex] > secondMax)
    {
        secondMax = arr[currentIndex];
    }

    currentIndex++;
}

Console.WriteLine(secondMax);

