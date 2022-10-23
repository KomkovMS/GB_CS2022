/*
2. Задача 48:

Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.

0 1 2 3
1 2 3 4
2 3 4 5

*/

// мое решение

// метод, который будет заполнять каждый элемент в массиве по формуле: Aₘₙ = i+j
int[,] FillArray(int[,] matr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = i + j;
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

// создаем двумерный массив размером m×n
int[,] matrix = new int[m, n];

// вызываем функцию, возвращающая матрицу, заполненную элементами по формулe i+j
int[,] Array = FillArray(matrix, m, n);

// вызываем функцию печати матрицы
PrintArray(Array, m, n);