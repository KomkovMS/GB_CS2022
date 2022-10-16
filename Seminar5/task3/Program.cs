/*
3. Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/

// мое решение

string СheckNumber(int[] col, int NumCheck)
{
    string result = string.Empty;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] == Math.Abs(NumCheck)) 
        {
            result = "да";
        } else {
            result = "нет";
        }
    }

    return result;
}


int[] array = {6, 7, 19, 345, 3};
var strArray = string.Join(", ", array);
Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numCheck = СheckNumber(array, number);
Console.Write($"[{strArray}] -> {numCheck}");