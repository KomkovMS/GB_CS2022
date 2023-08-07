/*
2. Задача 52: 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

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

// метод, который находит сумму элементов в каждом столбце
double[] GetSumOfColumns(int[,] matr, int m, int n)
{
    double[] result = new double[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[j] += matr[i, j]; 
        } 
    }

    return result;
}

// метод, который находит среднее арифметическое и печатает результат
void PrintAverageResult(double[] average, int m)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < average.Length; i++)
    {
        Console.Write($"{Math.Round(average[i] / m, 1)}; ");
    }
}

// метод, который печатает массив
void PrintArray(int[,] matr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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

// распечатаем получившийся двумерный массив
PrintArray(Array, m, n);

Console.WriteLine("================================");

// вызываем метод, который вернет сумму столбцов
double[] sumOfColumns = GetSumOfColumns(matrix, m, n);

// печатаем результат
PrintAverageResult(sumOfColumns, m);



