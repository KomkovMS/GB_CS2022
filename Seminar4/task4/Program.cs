﻿/*
4. Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

*/

// мое решение 1

int getArray()
{
    int[] arr = new int[8];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i]);              // 10100010
    }

    return arr.Length;  // непонятно что и зачем здесь возвращать, длину (для примера взял)
}

getArray();


// мое решение 1.1
Console.WriteLine("\n--------------------------------");

void getArr()
{
    int[] arr = new int[8];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i]);              
    }
}

getArr();


// мое решение 2
Console.WriteLine("\n--------------------------------");

// метод, который генерирует массив
void FillArray(int[] collection)
{
  for (int index = 0; index < collection.Length; index++)
  {
    collection[index] = new Random().Next(0, 2);
  }
}
 
// метод, который печатает массив
void PrintArray(int[] col)
{
  for (int index = 0; index < col.Length; index++)
  {
    Console.Write(col[index]);
  }
}
 

int[] array = new int[8];
FillArray(array);
PrintArray(array);

