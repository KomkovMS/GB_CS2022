/*
Задание на «разворот» массива. Нужно перевернуть массив и
записать его в обратном порядке (по схеме преподавателя на семинаре) 
*/

int[] arr = new int[]{3, 2, 12, 6, 9};
int len = arr.Length;

for (int i = 0; i < len/2; i++)
{
    int temp = arr[i];
    arr[i] = arr[len - i - 1];
    arr[len - i - 1] = temp;
}

Console.WriteLine(string.Join(", ", arr));
