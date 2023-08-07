/*
5. Написать программу сложения двух массивов

// [1,2,3]
// [3,2,1]

// [4,4,4]

*/

// мое решение

void PrintArray(int[] arr1, int[] arr2, int[] arrRes)
{
    for (int i = 0; i < arrRes.Length; i++)
    {
        arrRes[i] = arr1[i] + arr2[i];
        Console.Write($"{arrRes[i]} ");
    }
}


// или 
void PrintArray2(int[] arr1, int[] arr2, int[] arrRes)
{
    for (int i = 0; i < arrRes.Length; i++)
    {
        arrRes[i] = arr1[i] + arr2[i];
    }
    Console.WriteLine(string.Join(", ", arrRes));
}



int[] arr1 = new int[3]{1,2,3};
int[] arr2 = new int[3]{3,2,1};
int[] arrRes = new int[3];   // или int[] arrRes = {0, 0, 0}


PrintArray(arr1, arr2, arrRes);
Console.WriteLine("\n--------------------------");
PrintArray(arr1, arr2, arrRes);


