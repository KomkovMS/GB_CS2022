/*
4. Задача 51: 
В матрице чисел найти сумму элементов главной диагонали

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

// метод, который будет искать сумму значений главной диагонали
int GetSumMainDiagonal(int[,] matr, int m, int n)
{
    int result = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                result += matr[i, j];
            }
        }
    }

    return result;
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

// вызываем метод, который вернет сумму значений главной диагонали
int sumMainDiagonal = GetSumMainDiagonal(matrix, m, n);

// печатаем результат
Console.WriteLine($"Сумма элементов главной диагонали: {sumMainDiagonal}");