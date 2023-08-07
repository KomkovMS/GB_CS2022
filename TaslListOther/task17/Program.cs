/*
Задача 2. Нарисовать блок-схему
Задание на «разворот» массива. Нужно перевернуть массив и
записать его в обратном порядке.
*/


// int[] m = new int[] { 0, 1, 2, 3, 4, 5, 6, 7};
// int n = m.Length;
// int per = 0;

// for (int i = 0; i < n - 1 - i; i++)
// {
//     per += m[i];
//     m[i] = m[n - 1 - i];
//     m[n - 1 - i] = per;
//     Console.WriteLine(m[i]);
// }


// вариант 2
Console.WriteLine();

int[] arr = new int[] {0, 1, 2, 3, 4, 5, 6, 7};
Console.WriteLine(String.Join(',', arr));

int len = arr.Length;
int[] rev = new int[len];

for (int i = 0; i < len; i++)
{
    rev[len - 1 - i] = arr[i];
}

for (int i = 0; i < len; i++)
{
    arr[i] = rev[i];
}

Console.WriteLine(String.Join(',', arr));