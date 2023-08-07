/*
3. Задача 58: 

Задайте две матрицы. Напишите программу, которая будет находить произведение 
двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

// метод, который будет заполнять матрицы случайными значениями
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

// метод, который печатает массивы - множители
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

// метод, который возвращает произведение матриц
int[,] GerResult(int[,] matr1, int[,] matr2, int m, int n)
{
    int[,] matrRes = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < m; y++)
            {
                matrRes[i, j] += matr1[i, y] * matr2[y, j];
            }
        }
    }

    return matrRes;
}

// метод, который печатает результат работы программы в консоль
void PrintResult(int[,] result, int m, int n)
{
    Console.WriteLine("Результирующая матрица будет: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            
            Console.Write($"{result[i, j]} ");
        }

        Console.WriteLine();
    }
}


// задаем количество строк (m) = рядов (n)
int m = 2, n = 2;

// задаем макс и мин значения генерируемых элементов массива
int min = 0, max = 10;

// создаем переменную для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерные массивы размером m×m
int[,] matrixOne = new int[m, n];
int[,] matrixTwo = new int[m, n];

// вызываем функцию, возвращающая матрицы, заполненные случайными значениями
int[,] ArrayOne = FillArray(matrixOne, m, n, min, max, rnd);
int[,] ArrayTwo = FillArray(matrixTwo, m, n, min, max, rnd);

// вызываем метод, который возвращает результат перемножения матриц
int[,] result = GerResult(ArrayOne, ArrayTwo, m, n);


// ---------- вывод результата в консоль -----------
Console.WriteLine();

// распечатаем получившиеся двумерные массивы
PrintArray(ArrayOne, m, n);
Console.WriteLine("---");
PrintArray(ArrayTwo, m, n);

Console.WriteLine("=============================");

// выводим массив, являющийся результатом перемножения матриц
PrintResult(result, m, n);
Console.WriteLine();







// res[0,0] = matr1[0,0] * matr2[0,0] + matr1[0,1] * matr2[1,0];
// res[0,1] = matr1[0,0] * matr2[0,1] + matr1[0,1] * matr2[1,1];
// res[1,0] = matr1[1,0] * matr2[0,0] + matr1[1,1] * matr2[1,0];
// res[1,1] = matr1[1,0] * matr2[0,1] + matr1[1,1] * matr2[1,1];

// Console.WriteLine($"{res[0,0]} {res[0,1]}");
// Console.WriteLine($"{res[1,0]} {res[1,1]}");
