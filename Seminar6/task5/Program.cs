/*

5. Задача 45: 
Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования

*/

// мое решение

int[] GetArrCopy(int[] arr)
{
    int[] arrNew = new int[7];

    for (int i = 0; i < arr.Length; i++)
    {
        arrNew[i] = arr[i];
    }

    return arrNew;
}


int[] arr = new int[7]{23, 2, 54, 47, 4, 8, 12};
int[] arrCopy = GetArrCopy(arr);

var str = string.Join(", ", arrCopy);

Console.Write(str);

