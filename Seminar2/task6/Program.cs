/*
6. Напишите программу, которая будет выдавать название дня недели по заданному 
номеру.

3 -> Среда 
5 -> Пятница

Решить с помощью массива
*/


// мое решение
Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

string[] arrDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

Console.WriteLine(arrDays[day]);

// решение на семинаре
// аналогично


