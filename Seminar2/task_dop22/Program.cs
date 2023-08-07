/*
22. Найти расстояние между точками в пространстве 2D

1. Откуда значение
2. Вычисление (теорема пифагора)
3. Печать результата

*/

// 1. Откуда значение
double GetValue(string text)
{
    Console.WriteLine(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

// 3. Печать результата
void Print(double ax, double ay, double bx, double by, double result)
{
    // пример, | A(1, 2); B(4, 5) | = 5 условно
    // string output = "|A(" + ax + ", " + ay + "); B(" + 
    //                         bx + ", " + by + ")| = " + 
    //                         Math.Round(result, 2);

    // можно записать по другому:
    string output = $"|A({ax}, {ay}); B({bx}, {by})| = {Math.Round(result, 2)}";
    Console.WriteLine(output);
}


// 2. Вычисление (теорема пифагора)
double GetDistance(double ax, double ay, double bx, double by)
{
    // double x = (ax - bx) * (ax - bx); // тоже самое что и с помощью метода:
    // double y = Math.Pow(ay - by, 2);
    // double result = Math.Sqrt(y + x);
    // return result;
    // короткая запись того что записано выше (тоже самое):
    return Math.Sqrt(Math.Pow(ay - by, 2) + (ax - bx) * (ax - bx));
}

// здесь пишем клиентский код:

// 1. Откуда значение (ВЫЗОВ - подставляем нужный текст)
double ax = GetValue("Введите координату ax");
double ay = GetValue("Введите координату ay");
double bx = GetValue("Введите координату bx");
double by = GetValue("Введите координату by");

// 2. Вычисление (теорема пифагора) - ВЫЗОВ
double dis = GetDistance(ax, ay, bx, by);

// 3. Печать результата (ВЫЗОВ - подставляем введенные пользователем значения)
Print(ax, ay, bx, by, dis);

// Console.WriteLine(GetDistance(0, 0, 0, 10));
// Console.WriteLine(GetDistance(0, 0, 10, 0));
// Console.WriteLine(GetDistance(0, 0, 1, 1));
