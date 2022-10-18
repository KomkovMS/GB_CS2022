/*
Создать массив и проверить входят ли в него значения и в каком колличестве
*/

int[] arr = new int[10];

// заполнение массива
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Random.Shared.Next(0, 30);
}

// печать массива
Console.WriteLine(String.Join(" ", arr));

// вспомагательный массив, котторый хранит в себе информацию, есть ли
// элемент в массиве  шnt[] arr = new int[10] или нет
bool[] el = new bool[30];

// пробегаемся по исходному массиву: если какой-то элемент есть мы помечаем
// значение в истину
for (int i = 0; i < arr.Length; i++) el[arr[i]] = true;

// пробегаемся по массиву флагов: если элемент в true, то мы его показываем
for (int i = 0; i < el.Length; i++)
{
    // if (el[i]) Console.WriteLine(i); или так

    if (el[i])
    {
        Console.WriteLine($"{i} {Array.FindAll(arr, e => e == i).Count()}");
    }
}