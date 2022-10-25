/*
3. Задача 58: 

Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// // метод, который сравнивает входящую позицию элемента в двумерном массиве,
// // и возвращает результат
// string GetElementPosition(int[,] matr, 
//                        int m, 
//                        int n, 
//                        int number,
//                        string txt)
// {
//     string result = string.Empty;
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (matr[i, j] == number) result = Convert.ToString(matr[i, j]); 
//         } 
//     }

//     return result;
// }

// // метод, который печатает значение найденного элемента в массиве или 
// // же указание, что такого элемента нет
// void PrintResult(string result, string txt, int number)
// {
//     if (result == string.Empty) Console.WriteLine($"{number} -> {txt}");
//     else Console.WriteLine($"{number}");
// }

// метод, который печатает начальные массивы
void PrintArray(int[,] matr1, int[,] matr2, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr1[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("----------");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr2[i, j]} ");
        }
        Console.WriteLine();
    }




}

int[,] GerResult(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int y = 0; y < matr1.GetLength(1); y++)
            {
                matrRes[i, j] += matr1[i, y] * matr2[y, j];
            }
        }
    }
    return matrRes;

    // int[,] res = new int[m, n];

    
    // res[0,0] = matr1[0,0] * matr2[0,0] + matr1[0,1] * matr2[1,0];
    // res[0,1] = matr1[0,0] * matr2[0,1] + matr1[0,1] * matr2[1,1];
    // res[1,0] = matr1[1,0] * matr2[0,0] + matr1[1,1] * matr2[1,0];
    // res[1,1] = matr1[1,0] * matr2[0,1] + matr1[1,1] * matr2[1,1];


    // Console.WriteLine($"{res[0,0]} {res[0,1]}");
    // Console.WriteLine($"{res[1,0]} {res[1,1]}");

    // for (int i = 0; i < 3; i++)
    // {
    //     for (int j = 0; j < 3; j++)
    //     {
    //         Console.WriteLine(res[i,j]);
    //     }
    // }
    
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


// ---------- вывод результата в консоль -----------

// распечатаем получившиеся двумерные массивы
PrintArray(ArrayOne, ArrayTwo, m, n);

Console.WriteLine("================================");

int[,] result = GerResult(ArrayOne, ArrayTwo);



// // вызываем метод, который вернет значение элемента
// string elementPosition = GetElementPosition(matrix, m, n, number, txt);

// // печатаем результат в виде элемента, если он есть или указание, что его нет)
// PrintResult(elementPosition, txt, number);