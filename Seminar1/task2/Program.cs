// 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// мое решение
Console.WriteLine("Enter the number a: ");    // 35
string input1 = Console.ReadLine();
int a = Convert.ToInt32(input1);
Console.WriteLine("Enter the number b");      // 7
string input2 = Console.ReadLine();
int b = Convert.ToInt32(input2);

if (b * b == a) 
{
  Console.WriteLine("Да, число " + a + " является квадратом числа " + b); // Да, число 36 является квадратом числа 6
}

else
{
  Console.WriteLine("Нет, число " + a + " НЕ является квадратом числа " + b); // нет, число 35 НЕ является квадратом числа 7
}

// на семинаре
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Б");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB) {
  Console.WriteLine("yes");
} else {
  Console.WriteLine("no");
}