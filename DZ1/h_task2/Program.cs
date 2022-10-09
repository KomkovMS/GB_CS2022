/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int num1 = new Random().Next(0, 100);  // генерируем число 1
Console.Write(num1 + " "); // выводим число 1
int num2 = new Random().Next(0, 100);  // генерируем число 2
Console.Write(num2 + " "); // выводим число 2
int num3 = new Random().Next(0, 100);  // генерируем число 3
Console.Write(num3 + " "); // выводим число 3
int MaxNum; // задаем переменную максимального числа


if (num1 > num2 && num1 > num3) {
  MaxNum = num1;
}
else if (num2 > num1 && num2 > num3) {
  MaxNum = num2;
}
else {
  MaxNum = num3;
}

Console.Write("-> " + MaxNum);

// ПРИМЕР РЕШЕНИЯ ЗАДАЧИ ДРУГОГО УЧЕНИКА НА СЕМИНАРЕ 2

Console.WriteLine("\n Задача №2");
Console.WriteLine("----------------------------------------");

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine("Максимальным из трех чисел (" + numberA + ", " + numberB +", " + numberC + ") является число " + max);