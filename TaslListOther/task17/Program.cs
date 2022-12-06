/*
Задача 2. Нарисовать блок-схему
Задание на «разворот» массива. Нужно перевернуть массив и
записать его в обратном порядке.
*/


int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7};
int len = arr.Length;
int[] arr2 = arr;

for (int i = len - 1; i >= 0; i--)
{
    arr2[i] = arr[i];
    arr[i] = arr2[i];
    Console.Write(arr[i]);
}
