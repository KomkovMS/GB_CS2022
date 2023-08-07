/*

2. Задача 56: 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка

*/


int GetRowsSum(int[,] matr, int rows, int columns)
{
    int sumMinItem = 0; 
    int rowsCount = 0;

    for (int i = 0; i < rows; i++)
    {
        int sumItem = 0;

        for (int j = 0; j < columns; j++)
        {
            sumItem += matr[i, j];
        }
        if (i == 0) sumMinItem = sumItem;
        if (sumItem < sumMinItem)
        {
            sumMinItem = sumItem;
            rowsCount = i;
        }
    }

    return rowsCount;
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

int countRowsSum = GetRowsSum(matrix, m, n);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: " + 
                  $"{countRowsSum + 1}");
