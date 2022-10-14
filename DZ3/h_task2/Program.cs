/*
2. Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}


void Print(double ax, double ay, double az, 
           double bx, double by, double bz, 
           double result)
{
    string output = $"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> " +
                    $"{Math.Round(result, 2)}";
    Console.WriteLine(output);
}


double GetDist(double ax, double ay, double az, 
               double bx, double by, double bz)
{
    double x = Math.Pow(ax - bx, 2);
    double y = Math.Pow(ay - by, 2);
    double z = Math.Pow(az - bz, 2);
    double result = Math.Sqrt(y + x + z);
    return result;
}


double ax = GetValue("Введите координату ax ");
double ay = GetValue("Введите координату ay ");
double az = GetValue("Введите координату az ");
double bx = GetValue("Введите координату bx ");
double by = GetValue("Введите координату by ");
double bz = GetValue("Введите координату bz ");


double dis = GetDist(ax, ay, az, bx, by, bz);


Print(ax, ay, az, bx, by, bz, dis);


// вариант решения преподавателя на семинаре 4

double getDistance = (double x1, double y1, double z1, double x2, double y2, double z2) {
    double distance = 0;

    if (x1 == x2 && y1 == y2 && z1 == z2) 
    {
        return distance;
    }

    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return distance;
}


