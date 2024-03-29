﻿

string[,] table = new string[2, 5];
// String.Empty - инициализация строки
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

table[1, 2] = "слово";

// распечатаем данный массив

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int cols = 0; cols < 5; cols++)
//     {
//         Console.WriteLine($"-{table[rows, cols]}-");
//     }
// }

// тоже самое с числами


// Опишем метод, который будет печатать двумерную матрицу и заполнять ее числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

// метод, который будет заполнять матрицу случайными цифрами

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
