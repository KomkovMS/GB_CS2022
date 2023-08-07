/*
1. Напишите программу, которая на вход принимает число и выдает его квадрат 
(число, умноженное на само себя)
Например: 4 -> 16
          -3 -> 9
          -7 -> 49
*/

// мое решение
int number = new Random().Next(-10, 10);
Console.WriteLine("Квадрат числа " + number); // Квадрат числа -6
number *= number;
Console.WriteLine("равен: " + number);        // равен: 36

// на семинаре
Console.WriteLine("Enter the number");
int number2 = Convert.ToInt32(Console.ReadLine()); // -6
int quad = number2 * number2;
Console.WriteLine(quad);                           // 36

// на семинаре преподаватель
Console.WriteLine("Enter the number");
string input = Console.ReadLine();
int a = Convert.ToInt32(input);
int result = a * a;
Console.WriteLine("Квадрат числа " + a + " = " + result);

// на семинаре преподаватель (2)
Console.WriteLine("start");

int value = 4;
int result2 = value * value;
Console.WriteLine(result2);

Console.WriteLine("end");