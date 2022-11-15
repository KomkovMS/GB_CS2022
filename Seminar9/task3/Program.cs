/*
Масштабирование (для игры в тертрис, например)
*/

int[,] Resize(int[,] f, int c)
{
    int rows = f.GetLength(0);
    int columns = f.GetLength(1);
    int[,] res = new int[rows * c, columns * c];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = i * c; k < i * c + c; k++)
            {
                for (int l = j * c; l < j * c + c; l++)
                {
                    res[k, l] = f[i, j];
                }
            }
        }
    }

    return res;
}
int[,] f = new int[,] {
    { 0,1,0},
    { 1,0,1},
    { 0,0,1},
};

int[,] r = Resize(f, 3);

for (int i = 0; i < r.GetLength(0); i++)
{
    for (int j = 0; j < r.GetLength(1); j++)
    {
        Console.Write($"{r[i, j]}");
    }

    Console.WriteLine();
}

