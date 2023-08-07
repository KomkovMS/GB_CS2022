// Методы

// Вид 1

void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1();

// Вид 2.1 - ничего не возвращают, но могут принимать аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Hello");

// Вид 2.2 - явное указание аргумента

void Method22(string msg)
{
    Console.WriteLine(msg);
}

Method22(msg: "Текст сообщения");

void Method222(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method222(count: 4, msg: "Text");  // в таком формате можно менять местами

// Вид 3 - что то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
// Method3(); или
int year = Method3();
Console.WriteLine(year);

// Вид 4 - что то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // ТОже самое что и = ""
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res = Method4(10, "w");
Console.WriteLine(res);