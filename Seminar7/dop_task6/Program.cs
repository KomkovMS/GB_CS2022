/*
Разворот массива

*/

// 1 2 3
// 4 5 6
// 7 8 9

// 7 4 1
// 8 5 2
// 9 6 3

// [0,0] [0,1] [0,2]
// [1,0] [1,1] [1,2]
// [2,0] [2,1] [2,2]

// [0,0] -> [0,2]
// [0,1] -> [1,2]
// [0,2] -> [2,2]
// ->
// [1,0] -> [0,1]
// [1,1] -> [1,1]
// [1,2] -> [2,2]
// ->
// [2,0] -> [0,0]
// [2,1] -> [1,0]
// [2,2] -> [2,0]

// a00 a01 a02 a03 ... a0M
// a10 a11 a12 a13 ... a1M
// a20 a21 a22 a23 ... a2M
// a30 a31 a32 a33 ... a3M
//     ...
// aN0 aN1 aN2 aN3 ... aNM


// a00 a01 a02 a03 ... a00
// a10 a11 a12 a13 ... a1M
// a20 a21 a22 a23 ... a2M
// a30 a31 a32 a33 ... a3M
//     ...
// aN0 aN1 aN2 aN3 ... aNM


// a00 -> a0(M-1)
// далее проделать тоже самое с общим видом

int[,] Rotate(int[,] source)
{
    int rows = source.GetLength(0);
    int columns = source.GetLength(1);
    int[,] res = new int[rows, columns]; // если неравный можно поменять местами

    for (int j = 0; j < rows; j++)
    {
        for (int i = 0; i < columns; i++)
        {
            res[i, rows -1 - j] = source[j, i];
        }
    }

    return res;
}

void Print(int[,] map)
{
    int rows = map.GetLength(0);
    int columns = map.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{map[i, j], 2}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ar1 = {{1, 2, 3, 0},
              {4, 5, 6, 0},
              {7, 8, 9, 0},
              {0, 0, 0, 0}};

Print(ar1);
var ar2 = Rotate(ar1);
Print(ar2);