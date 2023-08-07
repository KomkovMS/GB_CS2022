/*
1. Задача 50: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

*/

// вариант решения преподавателя + моя оптимизация

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

// метод, который возвращает истину если позиция вне диапазона
bool GetValue(int[,] matr, 
              int m, 
              int n, 
              int iItem, 
              int jItem)
{
    return (iItem >= m || 
            jItem >= n || 
            iItem < 0 || 
            jItem < 0);
}

// метод, который печатает результат
void PrintResult(int[,] matr, 
                 int m, 
                 int n, 
                 bool result, 
                 string txt, 
                 int iItem, 
                 int jItem)
{
    if (result == false) Console.Write(($"{matr[iItem, jItem]}"));
    else Console.Write($"{iItem}; {jItem} {txt}");
}

// запрашиваем у пользователя количество строк (m) и рядов (n)
Console.WriteLine("Введите размерность массива M и N: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

// запрашиваем у пользователя позиции i и j для поиска в массиве
Console.WriteLine("Введите позиции i и j элемента в массиве: ");
int iItem = Convert.ToInt32(Console.ReadLine());
int jItem = Convert.ToInt32(Console.ReadLine());

// задаем макс и мин значения генерируемых элементов массива
int min = 1, max = 10;

// создаем переменную для генерации случайных значений элементов массива
Random rnd = new Random();

// создаем двумерный массив размером m×n
int[,] arr = new int[m, n];

// вызываем функцию, возвращающая матрицу, заполненную случайными значениями
int[,] Array = FillArray(arr, m, n, min, max, rnd);


// ---------- вывод результата в консоль -----------

// распечатаем получившийся двумерный массив
PrintArray(Array, m, n);

Console.WriteLine("========================================");

// создаем переменную с ответом, что такого числа нет в массиве
string txt = " -> на данной позиции такого числа в массиве нет";

// вызываем метод, который возвращает истину если позиции нет в массиве
bool result = GetValue(Array, m, n, iItem, jItem);

// печатаем результат в виде элемента, если он есть или указание, что его нет)
PrintResult(Array, m, n, result, txt, iItem, jItem);
