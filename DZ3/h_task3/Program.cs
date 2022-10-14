/*
3. Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void getCube(string msg, int num)
{
    for (int idx = 1; idx <= num; idx++)
    {
        if (idx < num) {
            Console.Write(idx * idx * idx + ", ");
        } else {
            Console.Write(idx * idx * idx);
        }
    }
}

string msg = "Введите число: ";
Console.WriteLine(msg);
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("-> ");


getCube(msg, num);


// вариант решения преподавателя на семинаре 4

int[] cubes = ()
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[N];

    for (int i = 1; i <= N; i++)
    {
        result[i] = i * i * i;
    }

    return result;
}

