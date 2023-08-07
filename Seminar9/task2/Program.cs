/*
Возвращение из метода
*/

Worker Get()
{
    return new Worker();
}

var pair = Get();
Console.WriteLine(pair.age);