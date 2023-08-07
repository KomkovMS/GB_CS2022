 /*
 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
 */

// мое решение

void getNum()
{
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    PrintRes(num1, num2);
}


void PrintRes(int num1, int num2)
{
    if (num1 % num2 == 0) 
    {
        Console.WriteLine($"Число {num2} кратно {num1}");
    } else 
    {
        Console.WriteLine($"Остаток числа {num1} от {num2} равен: {num1 % num2}");
    }
}


getNum();