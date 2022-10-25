// Task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("This program implements matrix multiplication: A x B = C.");
Console.WriteLine();
int numberRowMatrixA = EnterUserData("Enter number of rows for Matrix A: ");
int numberColMatrixA = EnterUserData("Enter number of columns for Matrix A: ");
int numberRowMatrixB = EnterUserData("Enter number of rows for Matrix B: ");
int numberColMatrixB = EnterUserData("Enter number of columns for Matrix B: ");
int lowerLim = EnterUserData("Enter lower limit for random range:");
int upperLim = EnterUserData("Enter upper limit for random range:");
int precision = EnterUserData("Enter precision for numbers: ");
double[,] matrixA = new double[numberRowMatrixA, numberColMatrixA];
double[,] matrixB = new double[numberRowMatrixB, numberColMatrixB];
double[,] matrixResult = new double[numberRowMatrixA, numberColMatrixB];

if (numberColMatrixA != numberRowMatrixB)
{
    Console.WriteLine("The number of columns of the Matrix A must be equal to the number of rows of the Matrix B! You cannot multiply these matrices!");
    return;
}

Console.WriteLine();
FillArray(matrixA, numberRowMatrixA, numberColMatrixA, lowerLim, upperLim, precision);
Console.WriteLine("Matrix A:");
PrintArray(matrixA);
Console.WriteLine();

FillArray(matrixB, numberRowMatrixB, numberColMatrixB, lowerLim, upperLim, precision);
Console.WriteLine("Matrix B:");
PrintArray(matrixB);
Console.WriteLine();

matrixResult = MatrixMultiply(matrixA, matrixB);
Console.WriteLine("Multiplication A x B =");
Console.WriteLine();
PrintArray(matrixResult);

double[,] MatrixMultiply(double[,] matrixA, double[,] matrixB)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int n = 0; n < matrixA.GetLength(1); n++)
            {
                matrixResult[i, j] += matrixA[i, n] * matrixB[n, j];
            }
        }
    }
    return matrixResult;
}

double[,] FillArray(double[,] array, int numberRow, int numberCol, int lowerLim, int upperLim, int precision)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double randomNum = new Random().NextDouble() * (upperLim - lowerLim);
            array[i, j] = Math.Round(randomNum, precision);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}