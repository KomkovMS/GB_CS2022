/*
Задача - перенести самое большое значение элемента массива в правый край массива
[2, 5, 13, 7, 6, 4]
*/

int[] numbers = new int[] {2, 5, 13, 7, 6, 4};
int size = numbers.Length;
int maxIdx = 0;
int max = numbers[maxIdx];

for (int index = 0; index < size; index++)
{
    if (numbers[index] > max)
        {
            maxIdx = index;
            max = numbers[index];
        }
}

numbers[maxIdx] = numbers[size - 1];
numbers[size - 1] = max;

Console.WriteLine($"[{string.Join(", ", numbers)}]"); // {2, 5, 7, 6, 4, 13}
