/*
2. Задача 18: 
Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/


// мое решение

void outputNum(string message)
{
    while (true)
    {
        Console.Write(message);
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 5 || num <= 0) {
            Console.WriteLine("Такой четверти не существует");
        } else {
            getPoint(num);
            break;
        }
    }
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

// аналогичное
