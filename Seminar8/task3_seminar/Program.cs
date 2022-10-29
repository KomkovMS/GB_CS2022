/*
3. Задача 55: 
Задайте двумерный массив. Напишите программу, которая заменяет строки на 
столбцы. В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.

*/

// решение на семинаре


int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1); 
        }
    }

    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");     
        }

        Console.WriteLine();
    }
}

void PrintReverseArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[j, i] + "\t");     
        }

        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

if (rows != columns)
{
    Console.WriteLine("Заменять элементы нельзя");
    return;
}

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

Console.WriteLine("Результат: ");
PrintReverseArray(array);