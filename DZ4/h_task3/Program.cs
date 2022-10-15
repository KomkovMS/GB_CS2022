/*
3. Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

// метод, который генерирует массив
void FillArray(int[] collection, int min, int max)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(min, max);
  }
}
 
// метод, который печатает массив
void PrintArray(int[] col)
{
    Console.Write("-> ");
    for (int index = 0; index < col.Length; index++)
    {
        if (index < col.Length - 1) {
            Console.Write($"{col[index]}, ");
        } else {
            Console.Write($"{col[index]}");
        }
    }

    // или вариант 2
    Console.Write("\n-> ");
    var str = string.Join(", ", col);
    Console.WriteLine(str); 
}
 

int[] array = new int[8];
FillArray(array, 1, 50);
PrintArray(array);