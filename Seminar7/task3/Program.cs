/*
3. Задача 49: 
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.

Например, изначально массив       Новый массив будет выглядеть 
выглядел вот так:                 вот так:

1 4 7 2                           1 4 7 2
5 9 2 3                           5 81 2 9
8 4 2 4                           8 4 2 4

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

// метод, который будет искать четные i && j и возводить из в квадраты
int[,] GetEvenSquared(int[,] matr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] % 2 == 0)
            {
                matr[i, j] *= matr[i, j];
            }
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

// задаем количество строк (m) и рядов (n)
int m = 3, n = 4;

// задаем макс и мин значения генерируемых элементов массива
int min = 1, max = 10;

// создаем переменную для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерный массив размером m×n
int[,] matrix = new int[m, n];

// вызываем функцию, возвращающая матрицу, заполненную случайными значениями
int[,] Array = FillArray(matrix, m, n, min, max, rnd);

// распечатаем первоначальный двумерный массив
PrintArray(Array, m, n);

Console.WriteLine("\n================================");

// вызываем функцию, которая вернет матрицу, 
// у которой четные индексы будут возведены в квадраты
int[,] ArrayEvenSquared = GetEvenSquared(matrix, m, n);

// вызываем функцию печати матрицы, в которую внесены изменения
PrintArray(ArrayEvenSquared, m, n);