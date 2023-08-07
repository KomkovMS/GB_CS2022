/*
5. Задача 59: 

Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых 
расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7

*/
 
int rows = 3;
int columns = 3;
 
int[,] matrix = new int[rows, columns];
 
int minValue = int.MaxValue; //Значение минимального элемента
int minIndexRows = 0;        //Задание индекса минимального элемента (строчка)
int minIndexColumns = 0;     //Задание индекса минимального элемента (столбец)
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0,10]
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        // minValue = 5(пусть)
        // 5>0, то минимум уже не 5, minValue = 0
        {
            minValue = matrix[i, j];
            minIndexRows = i;
            minIndexColumns = j;
        }
 
    }
    Console.WriteLine();
}
Console.WriteLine("Минимум:" + minValue);
System.Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++) // rows = GetLength(0)
{
    if (i != minIndexRows)
    {
        for (int j = 0; j < columns; j++) //columns - GetLength(1)
        {
            if (j != minIndexColumns)
            {
                Console.Write(matrix[i,j] + "\t");
 
            }
        }
        System.Console.WriteLine();
    }
}

