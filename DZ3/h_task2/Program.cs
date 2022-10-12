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