/*

Задача с файлами

*/


// считать файл

string path = @"\Users\maxko\SC\Seminar8\task6_dop\file.txt";
string text = File.ReadAllText(path);

int pos = text.IndexOf("\n");

int a = 0, b = 0;
string[] lines = File.ReadAllLines(path);
for (int i = 0; i < lines.Length; i++)
{
    string[] sysmols = lines[i].Split('=');
    if (sysmols[0].Trim() == "a") a = Convert.ToInt32(sysmols[1].Trim());
    if (sysmols[0].Trim() == "b") b = Convert.ToInt32(sysmols[1].Trim());


    // for (int j = 0; j < sysmols.Length; j++)
    // {
    //     Console.WriteLine($"{i + 1}: >>{sysmols[j].Trim()}<<");
    // }
}

System.Console.WriteLine($"a = {a}, b = {b}");