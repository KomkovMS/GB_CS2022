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

// метод, который сравнивает входящую позицию элемента в двумерном массиве,
// и возвращает результат
string GetElementPosition(int[,] matr, 
                       int m, 
                       int n, 
                       int number,
                       string txt)
{
    string result = string.Empty;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] == number) result = Convert.ToString(matr[i, j]); 
        } 
    }

    return result;
}

// метод, который печатает значение найденного элемента в массиве или 
// же указание, что такого элемента нет
void PrintResult(string result, string txt, int number)
{
    if (result == string.Empty) Console.WriteLine($"{number} -> {txt}");
    else Console.WriteLine($"{number}");
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

// запрашиваем у пользователя число для поиска в массиве
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// создаем переменную с ответом, что такого числа нет в массиве
string txt = "такого числа в массиве нет";

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

// вызываем метод, который вернет значение элемента
string elementPosition = GetElementPosition(matrix, m, n, number, txt);

// печатаем результат в виде элемента, если он есть или указание, что его нет)
PrintResult(elementPosition, txt, number);