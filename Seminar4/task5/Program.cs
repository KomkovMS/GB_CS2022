// разделение клиентского кода (преимущество при записи в консоль и файл)
// метод цветного вывода в консоль

void Ui(string arg)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($">>> {arg} <<<");
    Console.ForegroundColor = color;
}


int Sum1(int a, int b)
{
    return a + b;
}

int Mult(int a, int b)
{
    return a * b;
}


void Sum2(int a, int b)
{
    Console.WriteLine(a+b);
}


Ui(Sum1(1,2).ToString());
Ui(Mult(3, 4).ToString());
File.WriteAllText("file.db", Sum1(1, 2).ToString());