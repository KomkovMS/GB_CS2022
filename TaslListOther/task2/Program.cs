/*
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

*/

// Отрица́ние ¬ 
// Дизъю́нкция ⋁ ИЛИ.
// Конъю́нкция ⋀ «И»
 
bool getLeftPart(bool x, bool y)
{
    bool leftPart = !(x || y);
    return leftPart;
}

bool getRightPart(bool x, bool y)
{
    bool rightPart = (!x) && (!y);
    return rightPart;
}

bool getBoolResult(bool leftPart, bool rightPart)
{
    return leftPart == rightPart;
}


bool x = true;
bool y = true;
bool leftPart = getLeftPart(x, y);
bool rightPart = getRightPart(x, y);
bool boolResult = getBoolResult(leftPart, rightPart);

Console.WriteLine($"¬(X ⋁ Y) = {leftPart}");
Console.WriteLine($"¬X ⋀ ¬Y = {rightPart}");
Console.WriteLine($"¬(X ⋁ Y) = ¬X ⋀ ¬Y -> {boolResult}");