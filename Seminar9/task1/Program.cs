/*
Метод, возвращающий массив
*/

int[] GetPair()
{
    int x = 123;
    int y = 321;

    return new int[] {x, y};
}

int[] pair = GetPair();


/*
Метод, возвращающий кортеж
*/

(int, int) GetPair2()
{
    int x = 123;
    int y = 321;

    return (x, y);
}

(int, int) pair2 = GetPair2();
int a = pair2.Item1;
int b = pair2.Item2;

Console.WriteLine(a);

/*
Апгрейд
*/

(int getX, int getY) GetPair3()
{
    int x = 123;
    int y = 321;

    return (x, y);
}

var pair3 = GetPair3();
int c = pair3.getX;
int d = pair3.getY;

Console.WriteLine(d);

/*
Апгрейд2
*/

(int getX, int getY) GetPair4()
{
    int x = 123;
    int y = 321;

    return (x, y);
}

(int value1, int value2) pair4 = GetPair4();
int e = pair4.value1;
int f = pair4.value2;

Console.WriteLine($"{e} и {f}");