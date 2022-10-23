/*
1. Задача 46: 
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1

*/

// мое решение

// метод, который будет заполнять матрицу случайными значениями
int[,] FillArray(int[,] matr, 
                 int m, 
                 int n, 
                 int min, 
                 int max, 
                 Random rnd)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = rnd.Next(min,max);
        }
    }

    return matr;
}

// метод, который печатает массив
void PrintArray(int[,] matr, int m, int n)
{
    for (int i = 0; i < m; i++)     // matr.GetLength(0)
    {
        for (int j = 0; j < n; j++) // matr.GetLength(1)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}

// задаем количество срок (m) и рядов (n)
int m = 3, n = 4;

// задаем макс и мин значения генерируемых элементов массива
int min = 1, max = 10;

// создаем переменную для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерный массив размером m×n
int[,] matrix = new int[m, n];

// вызываем функцию, возвращающая матрицу, заполненную случайными значениями
int[,] Array = FillArray(matrix, m, n, min, max, rnd);

// вызываем функцию печати матрицы
PrintArray(Array, m, n);