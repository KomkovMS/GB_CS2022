/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является 
ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

int num = new Random().Next(0, 100);  
Console.Write(num + " ");

if (num % 2 == 0) {
  Console.WriteLine("-> да");
}
else 
{
  Console.WriteLine("-> нет");
}


// ПРИМЕР РЕШЕНИЯ ЗАДАЧИ ДРУГОГО УЧЕНИКА НА СЕМИНАРЕ 2

Console.WriteLine("Задача №6");
Console.WriteLine("----------------------------------------");

Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0) 
{
    Console.Write("Число " + numberA +" четное");
}
else
{
    Console.Write("Число " + numberA +" нечетное");
}