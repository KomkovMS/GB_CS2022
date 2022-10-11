/*
4. Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

// мое решение

void outputNum(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    getSquareNumber(num);
}

void getSquareNumber(int num) {
    Console.Write("-> ");
    for (int i = 1; i <= num; i++)
    {
        if (i < num) {
            Console.Write(i*i + ", ");
        } else {
            Console.Write(i*i + ". ");
        }
    }
}


string message = "Введите число: ";
outputNum(message);



// решение на семинаре

int[] getArray(int number)  
{
    int[] arr = new int[number];
    int i = 1;
    while (i <= number) {
        arr[i-1] = i*i;
        Console.Write(arr[i-1] + " ");
        i++;
    }
    return arr;
}


Console.WriteLine("\n------------------------");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] res = getArray(number);

// for (int i = 1; i <= number; i++)
// {
//     arr[i-1] = i*i;
//     Console.Write(arr[i-1] + " ");
// }

// тоже самое с помощью цикла while




