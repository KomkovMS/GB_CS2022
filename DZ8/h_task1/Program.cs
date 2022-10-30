/*
1. Задача 54: 

Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

// метод, который сортирует элементы строк по убыванию
int[,] SortArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            for (int j = 0; j < columns - k - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }

    return array;
}

// метод, который будет заполнять матрицу случайными значениями
int[,] FillArray(int[,] matr, 
                 int rows, 
                 int columns, 
                 int min, 
                 int max, 
                 Random rnd)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = rnd.Next(min,max);
        }
    }

    return matr;
}

// метод, который печатает массив
void PrintArray(int[,] matr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


// задаем количество строк (m) и рядов (n)
int m = 3, n = 4;

// задаем макс и мин значения генерируемых элементов массива
int min = 0, max = 10;

// создаем переменную для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерный массив размером m×n
int[,] matrix = new int[m, n];

// вызываем функцию, возвращающая матрицу, заполненную случайными значениями
int[,] Array = FillArray(matrix, m, n, min, max, rnd);

// ---------- вывод результата в консоль -----------

Console.WriteLine("Задан массив: ");
PrintArray(Array, m, n);

// метод, который возвращает сортированный массив
int[,] sortArray = SortArray(matrix, m, n);

Console.WriteLine("В итоге получается вот такой массив: ");

PrintArray(sortArray, m, n);
