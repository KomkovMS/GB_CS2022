/*
Записать алгоритм, который "перенесет" самое большое значение элемента
в правый край массива (переработка по блок-схеме при попощи
"Пузырькового метода")
*/

int[] array = new int[]{4, 5, 2, 9, 12, 3, 0, 7};
int l = array.Length;

for (int i = 0; i < l; i++)
{
    for (int j = 0; j < l - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            array[j] = array[j + 1];
            array[j + 1] = array[j];
        }

        
    }

    Console.Write($"{array[i]} ");
}
