int a = 452;

for (int i = 0; i < a; i++)
{
    a += a % 10;
    Console.WriteLine("Первое число" + a);
}