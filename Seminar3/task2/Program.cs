/*
2. Задача 18: 
Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/


// мое решение

void outputNum(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    getPoint(num);
}


void getPoint(int num)
{
    if (num == 1) {
    Console.WriteLine($"Для четверти: {num} диапазон возможных координат точек: X > 0, Y > 0");
    }
    else if (num == 2) {
        Console.WriteLine($"Для четверти: {num} диапазон возможных координат точек: X < 0, Y > 0");
    }
    else if (num == 3) {
        Console.WriteLine($"Для четверти: {num} диапазон возможных координат точек: X < 0, Y < 0");
    } else {
        Console.WriteLine($"Для четверти: {num} диапазон возможных координат точек: X > 0, Y < 0");
    }
}


string message = "Введите номер четверти плоскости: ";
outputNum(message);


// решение на семинаре

