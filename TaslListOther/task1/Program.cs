/*
0.  Вывести квадрат числа
5 -> 25
*/

int GetQuadro(int number)
{
    int result = 0;
    result = number * number;

    return result;
}

void PrintResult(int number, int result)
{
    Console.WriteLine($"Квадрат числа {number} -> {result}");
}


Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int quadro = GetQuadro(num);
PrintResult(num, quadro);
