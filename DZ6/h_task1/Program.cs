/*
1. Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

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


    



