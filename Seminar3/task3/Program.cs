/*
3. Задача 21: 

Решение в группах задач:
AB = √(xb - xa)2 + (yb - ya)2

Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

// решено на семинаре 2 у другого преподавателя, см. task_dop22


// другое решение

double coordinatePoints(double x1, double y1, double x2, double y2)
{
    double result = 0;
    if (x1 == x2 && y1 == y2)
    {
        return result;
    }
    result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return result;
}

double Num = coordinatePoints(3, 6, 2, 1);
Console.WriteLine(Num);