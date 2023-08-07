/*
Парсинг строки. Увеличить каждую координату на N
*/

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
              .Replace("(", "")       
              .Replace(")", "")
              ;

var data = text.Split(" ")  // возьми текст и разбей его
               .Select(item => item.Split(',')) 
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
               .Where(e => e.x % 2 == 0)    // получим набор точек у которых первая координата четная
               .Select(point => (point.x * 10, point.y))
               .ToArray();  // превращение в явный массив

for (var i = 0; i < data.Length; i++)
{
   Console.WriteLine(data[i]);
}

