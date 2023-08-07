/*
Задача на скалярное произведение:

Записать алгоритм нахождения скалярного произведения двух векторов

Формула:
(a, b) * (c, d) = a * c + b * d
*/


int GetAScalarWork(int a, 
                   int b, 
                   int c, 
                   int d, 
                   int[] arr1, 
                   int[] arr2, 
                   int size)
{
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        result += arr1[i] * arr2[i];
    }

    return result;
}

int a = 1, b = 8, c = 3, d = 2;

int[] array1 = new int[2]{a, b};
int[] array2 = new int[2]{c, d};

int sizeArr = array1.Length;

int scalarWork = GetAScalarWork(a, b, c, d, array1, array2, sizeArr);
Console.WriteLine($"Скалярное произведение двух векторов = {scalarWork}");