/*
Задача 4:  Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int num = new Random().Next(1, 10);  
Console.Write(num + " ");

int count = 0;
Console.Write("-> ");

while (count < num)
{
  if (num % 2 == 0) {
    count += 2;
  }
  else {
    num -= 1;
    count += 2;
  }
  Console.Write(count + ", ");
}

// ПРИМЕР РЕШЕНИЯ ЗАДАЧИ ДРУГОГО УЧЕНИКА НА СЕМИНАРЕ 2

Console.WriteLine("\nЗадача №8");
Console.WriteLine("----------------------------------------");

Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i=1;

while (i<=numberA)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + ", \n");
    }
    i++;
}

// ПРИМЕР РЕШЕНИЯ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR НА СЕМИНАРЕ 2

for (int idx = 1; idx <= numberA; idx++)
{
  if (idx % 2 == 0) 
    {
      Console.Write(idx + ", ");
    }
}