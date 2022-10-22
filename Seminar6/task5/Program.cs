/*

5. Задача 45: 
Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования

*/

// мое решение

int[] arr = new int[7]{23, 2, 54, 47, 4, 8, 12};

int[] arrNew = new int[7]; // Array.Empty<int>();

for (int i = 0; i < arr.Length; i++)
{
    arrNew[i] = arr[i];
}

var str = string.Join(", ", arrNew);

Console.Write(str);
