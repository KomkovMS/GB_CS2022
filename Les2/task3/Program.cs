
int[] array = {11, 21, 31, 14, 15, 16, 71, 8, 19};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
      Console.WriteLine(index);
    }
    index++;
}