/*
50. В двумерном массиве n×k заменить четные элементы на противоположные
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

// метод, который заменит четные элементы на противоположные
int[,] ReplacingElement(int[,] matr, int m, int n)
{
    int[,] matrNew = matr;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] % 2 == 0) matrNew[i, j]++;
        }
    }
    return matrNew;
}

// метод, который печатает массив
void PrintArray(int[,] matr, int m, int n)
{
    for (int i = 0; i < m; i++)     // matr.GetLength(0)
    {
        for (int j = 0; j < n; j++) // matr.GetLength(1)
        {
            Console.Write($"{matr[i, j]}   ");
        }

        Console.WriteLine();
    }
}

// задаем количество срок (m) и рядов (n)
int m = 5, n = 5;

// задаем макс и мин значения генерируемых элементов массива
int min = 1, max = 100;

// создаем переменную для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерный массив размером m×n
int[,] matrix = new int[m, n];

// вызываем функцию, возвращающая матрицу, заполненную случайными значениями
int[,] Array = FillArray(matrix, m, n, min, max, rnd);

// вызываем функцию печати получившейся матрицы
PrintArray(Array, m, n);

// вызываем функцию, возвращающая матрицу, у котороый четные элементы заменены 
// на противоположные
int[,] arrReplacingElement = ReplacingElement(Array, m, n);

Console.WriteLine("\n------------------------");

// вызываем функцию печати результата
PrintArray(arrReplacingElement, m, n);
