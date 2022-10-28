/*
1. Задача 53: 
Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строку массива.

Например,

4 7 0   ->    5 6 1
5 6 1         4 7 0
*/

// решение на семинаре


// метод, отвечающий за заполнение массива рандомными числами
/// summary
/// m на n, m - кол-во строк
/// n - кол-во столбцов
/// minRandom, maxRandom
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++) // цикл по строчкам
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1); // [)
        }
    }

    return result;
}

// метод, который печатает массив
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++) // цикл по строчкам
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");  // тоже самое inputArray[i, j] + "    "  
            // 1    2    3    4
            // 5    6    7    8
            // 9    10   11   12 ...      
        }

        Console.WriteLine();
    }
}

// метод, который заменяет строку
void ChangeRows(int[,] matrix)
{
    int numberLastRow = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];                     // пузырьковый метод
        matrix[0,i] = matrix[numberLastRow,i];
        matrix[numberLastRow, i] = temp;
    }
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());  // аналог ConvertToInt32

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


// вызов исходного массива
int[,] array = GetArray(rows, columns, 0, 10);

// вызов метода, который печатает массив
PrintArray(array);

// вызов метода, который меняет местами строки массива
ChangeRows(array);

// печать результата
Console.WriteLine("Результат: ");
PrintArray(array);