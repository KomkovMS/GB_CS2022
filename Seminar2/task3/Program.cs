/*
3. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

// мое решение
void getResult(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine("-> кратно ");
    } else {
        int result = num1 % num2;
        Console.WriteLine("не кратно, остаток " + result);
    }
}

void getRandomNum(int start1, int start2, int end1, int end2)
{
    int num1 = new Random().Next(start1, end1);
    Console.WriteLine("Рандомное первое число: " + num1);

    int num2 = new Random().Next(start2, end2);
    Console.WriteLine("Рандомное второе число: " + num2);
    getResult(num1, num2);
}


getRandomNum(10, 1, 99, 9);

// решение на семинаре
// тоже самое






