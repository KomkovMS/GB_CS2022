// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	  3 -> Среда 
//    5 -> Пятница


// мое решение
int number = new Random().Next(-3, 11);
Console.WriteLine(number);

string Monday = "понедельник";
string Tuesday = "вторник";
string Wednesday = "среда";
string Thursday = "четверг";
string Friday = "пятница";
string Saturday = "суббота";
string Sunday = "воскресенье";

if (number == 1) {
  Console.WriteLine(Monday);
}
if (number == 2) {
  Console.WriteLine(Tuesday);
}
if (number == 3) {
  Console.WriteLine(Wednesday);
}
if (number == 4) {
  Console.WriteLine(Thursday);
}
if (number == 5) {
  Console.WriteLine(Friday);
}
if (number == 6) {
  Console.WriteLine(Saturday);
} 
if (number == 7) {
  Console.WriteLine(Sunday);
}
if (number >= 8 || number < 1) {
  Console.WriteLine("Введено не корректное значение");
}

// на семинаре с помощью switch

Console.WriteLine("Введите номер дня недели");
int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
  case 1:
    Console.WriteLine("понедельник");
    break;
  case 2:
    Console.WriteLine("вторник");
    break;
  case 3:
    Console.WriteLine("среда");
    break;
  case 4:
    Console.WriteLine("четверг");
    break;
  case 5:
    Console.WriteLine("пятница");
    break;
  case 6:
    Console.WriteLine("суббота");
    break;
  case 7:
    Console.WriteLine("воскресенье");
    break;
  default:
    Console.WriteLine("Введено не корректное значение");
    break;
};

