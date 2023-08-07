/*
3. Задача 55: 
Задайте двумерный массив. Напишите программу, которая заменяет строки на 
столбцы. В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.

*/

// мое решение

// 1 2 3
// 4 5 6
// 7 8 9

// 1 4 7
// 2 5 8
// 3 6 9

// [0,0] [0,1] [0,2]
// [1,0] [1,1] [1,2]
// [2,0] [2,1] [2,2]

// [0,0] -> [0,0]
// [0,1] -> [1,0]
// [0,2] -> [2,0]
// ->
// [1,0] -> [0,1]
// [1,1] -> [1,1]
// [1,2] -> [2,1]
// ->
// [2,0] -> [0,2]
// [2,1] -> [1,2]
// [2,2] -> [2,2]

// a00 a01 ... a0M
// a10 a11 ... a1M
// a20 a21 ... a2M
// a30 a31 ... a3M
//     ...
// aN0 aN1 ... aNM


// a00 a01 ... a00
// a10 a11 ... a1M
// a20 a21 ... a2M
// a30 a31 ... a3M
//     ...
// aN0 aN1 ... aNM



// метод, отвечающий за заполнение массива рандомными числами
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
    
    for (int i = 0; i < inputArray.GetLength(0); i++)
    { 
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");    
        }

        Console.WriteLine();
    }
    
}

// метод, который проверяет условие равенства строк и столбцов
bool getEquality(int rows, int columns)
{
    return rows == columns;
}

// метод, который заменяет строку на столбец
int[,] StringReplacement(int[,] source, int rows, int columns)
{
    int[,] res = new int[rows, columns]; 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j] = source[j, i];
        }
    }

    return res;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());  // аналог ConvertToInt32

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

// метод, который проверяет условие равенства строк и столбцов
bool equality = getEquality(rows, columns);

if (equality == false) Console.Write(($"Строки и столбцы неравны, замена не возможна"));
else 
{
    // вызов исходного массива
    int[,] array = GetArray(rows, columns, 0, 10);

    // печать сгенерированного массива
    PrintArray(array);

    // метод, возвращающий результат
    int[,] arrResult = StringReplacement(array, rows, columns);

    // печать результата
    Console.WriteLine("Результат: ");
    PrintArray(arrResult);
}





