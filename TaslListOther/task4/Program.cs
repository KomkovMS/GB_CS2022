/*
30. Показать кубы чисел, заканчивающихся на четную цифру

*/

int[] GetСubsArray(int num)
{
    int[] result = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        result[i] = i * i * i;
    }

    return result;
}

int[] GetСubsArrayEven(int[] arrCube)
{
    int[] result = new int[arrCube.Length];
    for (int i = 0; i < arrCube.Length; i++)
    {
        if (arrCube[i] % 2 == 0) result[i] = arrCube[i];
    }

    return result; 
}

void PrintResult(int[] cubsArrayEven)
{
    for (int i = 0; i < cubsArrayEven.Length; i++)
    {
        if (i == 0 || cubsArrayEven[i] > 0)
        {
            Console.WriteLine($"{cubsArrayEven[i]} ");
        }
    }
}


int num = 15;
int[] arrCube = GetСubsArray(num);
int[] cubsArrayEven = GetСubsArrayEven(arrCube);
PrintResult(cubsArrayEven);

//----------------------------------------------------------------
// логика
// for (int i = 0; i < num; i++)
// {
//     cube = Math.Pow(i, 3);
   
//     if (cube % 2 == 0) Console.Write($"{cube} ");
    
// }
