/*
Задача - перенести самое большое значение элемента массива в правый край массива
[2, 5, 13, 7, 6, 4]
*/

int[] numbers = new int[] {2, 5, 13, 7, 6, 4};
int index = 0;
int size = numbers.Length;
int maxIdx = 0;
int max = numbers[maxIdx];
int maximum = numbers[index];
int maximumIndex = index;

while (index < size)
{
    if (numbers[index] > maximum)
    {
        maximum = numbers[index];
        maximumIndex = index;
    }
    index += 1;
}

numbers[maximumIndex] = numbers[size - 1];
numbers[size - 1] = maximum;

Console.WriteLine($"[{string.Join(", ", numbers)}]"); // {2, 5, 7, 6, 4, 13}
