﻿// Рекурсия - продолжение

//n! = 1 ... n

int Factorial(int num)
{
    if (num == 1) return 1; // Факториал от 1 = 1(1*1)
    //Базовый случай для рекурсии
    return (num * Factorial(num - 1));
}

// Базовый случай - он позволяет выйти из рекурсии, условие выхода
// Рекурсивный случай - место, откуда повторно вызывается функция