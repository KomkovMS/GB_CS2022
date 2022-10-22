/*
1. Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

// мое решение

int[] GetArr(int n)
{
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}


int GetCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}


Console.WriteLine("Какое количество цифр вы хотите ввести? ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = GetArr(n);

int count = GetCount(array);

var str = string.Join(", ", array);
Console.WriteLine($"Вы ввели числа: {str} -> {count}");


// решение на семинаре от преподавателя

Console.WriteLine("\n------------------------");

int M = Convert.ToInt32(Console.ReadLine());
int countOfPositives = 0;
for (int i = 0; i < M; i++)
{
    int digit = Convert.ToInt32(Console.ReadLine());
    if (digit > 0) countOfPositives++;
}

Console.WriteLine("Positives: {0}", countOfPositives);



