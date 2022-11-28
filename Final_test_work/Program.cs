/*
Задача итоговой проверочной работы

Написать программу, которая из имеющегося массива строк формирует массив из 
строк, длина которых меньще либо равна 3 символа.

Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользователь коллекциями, 
лучше обойтись исключительно массивами.

*/

string[] getArray(string[] arr)
{
    string[] result = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[i] = arr[i];
        }
    }

    return result;
}


string[] array = {"123", "1567", "-2", "adf", "computer science"}; 
//{"hello", "2", "world", ":-)"};

string[] arrayThreeChar = getArray(array);


Console.WriteLine(string.Join(", ", arrayThreeChar));

