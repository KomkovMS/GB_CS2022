/*
Заполнить массив случайными числами (еще вариант)
*/

var arr = Enumerable.Range(1, 100)
                    .Select(e => Random.Shared.Next(0, 30))
                    .GroupBy(e => e)
                    .ToArray();

foreach (var item in arr)
{
    System.Console.WriteLine($"{item.Key} - {item.Count()}");
}