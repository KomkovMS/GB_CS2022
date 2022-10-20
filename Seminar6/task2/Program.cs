/*
2. Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.

/// Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон ///

*/

// мое решение

string GetAnswer(int n1, int n2, int n3, string msgPlus, string msgMinus)
{
    if (n1 < n2 + n3 && n2 < n3 + n1 && n3 < n1 + n2) return msgPlus;
    else return msgMinus;
}


int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);
int num3 = new Random().Next(1, 100);

string txtPlus = "Такой треугольник существовать может";
string txtMinus = "Нет";

string answer = GetAnswer(num1, num2, num3, txtPlus, txtMinus);

Console.WriteLine(num1 + " " + num2 + " " + num3);
Console.WriteLine(answer);


// решение на семинаре

Console.WriteLine("\n------------------------------------------");

int numA = new Random().Next(1, 100);
int numB = new Random().Next(1, 100);
int numC = new Random().Next(1, 100);

Console.WriteLine(numA + " " + numB + " " + numC);

bool checkA = numA < numB + numC;
bool checkB = numB < numC + numA;
bool checkC = numC < numA + numB;

if (checkA && checkB && checkC)
{
    Console.WriteLine("Такой треугольник существовать может");
}
else Console.WriteLine("Нет");