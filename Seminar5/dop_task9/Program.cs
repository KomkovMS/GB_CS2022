/*
Заполнить массив случайными числами (другой вариант)
*/

int GetItem(int el)
{
    return Random.Shared.Next(0, 30);
}

int[] arr = Enumerable.Range(1, 100)
            .Select(GetItem)
            .ToArray();


Console.WriteLine(String.Join(", ", arr));