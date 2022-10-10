/*
1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/

// мое решение

void outputСoordinatePoints(string messageX, string messageY)
{
    Console.Write(messageX);
    int coordinatePointsX = Convert.ToInt32(Console.ReadLine());

    Console.Write(messageY);
    int coordinatePointsY = Convert.ToInt32(Console.ReadLine());

    determinationOfTheCoordinates(coordinatePointsX, 
                                  coordinatePointsY, 1, 2, 3, 4);
}

void determinationOfTheCoordinates(int coordinatePointsX, int coordinatePointsY, 
                                   int numberOfQuarter1, int numberOfQuarter2, 
                                   int numberOfQuarter3, int numberOfQuarter4)
{
    if (coordinatePointsX > 0 && coordinatePointsY > 0) {
    Console.WriteLine($"Точка находится в {numberOfQuarter1}четверти плоскости");
    }
    else if (coordinatePointsX < 0 && coordinatePointsY > 0) {
        Console.WriteLine($"Точка находится в {numberOfQuarter2} четверти плоскости");
    }
    else if (coordinatePointsX < 0 && coordinatePointsY < 0) {
        Console.WriteLine($"Точка находится в {numberOfQuarter3} четверти плоскости");
    } else {
        Console.WriteLine($"Точка находится в {numberOfQuarter4} четверти плоскости");
    }
}


outputСoordinatePoints("Введите координату X: ", "Введите координату Y: ");

 
// решение на семинаре

// аналогично