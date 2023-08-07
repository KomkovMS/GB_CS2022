/*
Регулирование количества знаков после запятой
*/

double d = 123.456789012;
Console.WriteLine(string.Format("{0:F4}", d));
Console.WriteLine($"{d:F4}");
Console.WriteLine(d.ToString("### ###.### ###"));