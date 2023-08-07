/*
2. Задача 32: 
Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

// мое решение

// метод, который делает замену элементов массива

int[] GetReplacingElemOfArray(int[] col)
{
    int[] newCol = col;
    for (int i = 0; i < col.Length; i++)
    {
        newCol[i] *= -1;
    }
    return newCol;
}


int[] array = {-4, -8, 8, 2};
var strArray = string.Join(", ", array);
int[] newArr = GetReplacingElemOfArray(array);
var strNewArr = string.Join(", ", newArr);
Console.Write($"[{strArray}] -> [{strNewArr}]");

// решение на семинаре

// аналогичное