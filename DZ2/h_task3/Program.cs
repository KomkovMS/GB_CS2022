/*
3. Напишите метод, который принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

// мое решение

void getDay (int day, string[] arrDays)
{
    if (arrDays[day] == "Sun" || arrDays[day] == "Sat")
    {
        Console.WriteLine("-> да");
    }
    else
    {
        Console.WriteLine("-> нет");
    }
}

void enterNumDay ()
{
    while (true)
    {
        Console.WriteLine("Enter the day of the week: ");
        int day = Convert.ToInt32(Console.ReadLine()) - 1;
        string[] arrDays = new string[]
        {
            "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"
        };

        if (day < 0 || day + 1 > arrDays.Length)
        {
            Console.WriteLine("Invalid day number");
            Console.WriteLine("--------------------------------");

        }
        else
        {
            getDay(day, arrDays);
            break;
        }
    }
}

enterNumDay ();

// пример решения другого ученика на семинаре 3

Console.WriteLine("Задача №15");
Console.WriteLine("----------------------------------------");

string[] day = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

Console.Write("Введите целое число (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    Console.Write("Это " + day[number - 1]);
    if (number==6 || number==7)
    {
        Console.Write(" - выходной день.");
    }
}
else
{
    Console.WriteLine("Такого дня не существует!");
}
