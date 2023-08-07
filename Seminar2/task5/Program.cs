/*
5. Дано число N. Нужно создать массив с N - элементами, каждый элемент которого
будет соответствовать номеру этого элемента

Например,
5 -> 0, 1, 2, 3, 4
*/


// мое решение
void getResult(int num)
{
    int[] array = new int[num];

    int count = array.Length;
    int idx = 0;

    for (int i = 0; i < count; i++) {
        Console.Write(array[i] + idx++ + ", ");
    }
}

void getRandomNum(int start, int end)
{
    int num = new Random().Next(start, end);
    Console.WriteLine("Рандомное число: " + num);


    getResult(num);
}


getRandomNum(1, 10);


// решение на семинаре
Console.WriteLine("\n ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[number];

for (int i = 0; i < number; i++)
{
    arr[i] = i;
    Console.Write(arr[i] + ", ");
}



