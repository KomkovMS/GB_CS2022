
// метод, который генерирует массив
void FillArray(int[] collection)
{
  int length = collection.Length; // получить длину массива
  int index = 0; //
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}

// метод, который печатает массив
void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.Write(col[position] + " ");
    position++;
  }
}

// метод, который ищет нужную позицию в массиве
int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1; // искусственный прием, если элемента нет будет -1
  // -1 будем интерпретировать, что такой элемент не найден
  while (index < count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;  // почтому что ищем первое совпадение
    }
    index++;
  }
  return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);  // ищем четвертый элемент
Console.WriteLine(pos); // выведем на экран четвертый элемент

// void - метод, который ничего не возвращает, return не используется


// Пример вывода полученного результата при нахождении числа 4
// PS C:\Users\maxko\SC\Seminar2\task4> dotnet run
// 6 2 6 5 6 9 1 9 5 3 
// -1
// PS C:\Users\maxko\SC\Seminar2\task4> dotnet run
// 2 4 5 4 3 4 2 5 2 4 
// 1
// PS C:\Users\maxko\SC\Seminar2\task4> 