/*
5. Задача 47: Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

// мое решение

// метод, который будет заполнять матрицу случайными значениями
double[,] FillArray(double[,] matr, 
                 int m, 
                 int n, 
                 int min, 
                 int max, 
                 Random rnd,
                 int factor)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = Math.Round(
                                   rnd.NextDouble() * 
                                   factor * 
                                   (rnd.Next(min, max)), 
                                   1);
        }
    }

    return matr;
}

// метод, который печатает массив
void PrintArray(double[,] matr, int m, int n)
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

// задаем макс и мин значения генерируемых элементов массива и множитель
int min = -1, max = 2, factor = 10;

// создаем переменные для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерный массив размером m×n
double[,] matrix = new double[m, n];

// вызываем функцию, возвращающая матрицу, заполненную случайными значениями
double[,] Array = FillArray(matrix, m, n, min, max, rnd, factor);

// вызываем функцию печати матрицы
PrintArray(Array, m, n);