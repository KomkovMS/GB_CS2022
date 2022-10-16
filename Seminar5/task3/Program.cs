/*
3. Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/

// мое решение

bool СheckNumber(int[] col, int NumCheck)
{
    bool result = false;
    for (int i = 0; i < col.Length; i++)
    {
        if (Math.Abs(col[i]) == Math.Abs(NumCheck))
        {
            return true;
        }
    }

    return result;
}


int[] array = {6, 7, 19, 345, 3};
var strArray = string.Join(", ", array);
Console.WriteLine("Enter the number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
bool numCheck = СheckNumber(array, number);
Console.Write($"[{strArray}] -> {numCheck}");


// решение на семинаре

Console.Write("\n-----------------\n");

bool answer(int num)
{
    int[] newArr = new int[7]{8, 9, 63, 4, 8, 4, 6};
    bool ans = false;

    for (int i = 0; i < newArr.Length; i++)
    {
        if (newArr[i] == num) {
            return true;
        }
    }

    return ans;
}

bool a = answer(5);
Console.WriteLine(a);
bool b = answer(6);
Console.WriteLine(b);