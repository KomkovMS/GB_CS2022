/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8


// fn = fn-1 + fn-2

// f(1) = 1
// f(2) = 1 
// f(n) = f(n-1) + f(n-2)

f() = 
*/


void writeFib(int n)
{
    int fib1 = 0;
    int fib2 = 1;
    int sum = 0;

    if (n >= 1) {
        Console.Write(fib1 + " ");
    }
    if (n >= 2) {
        Console.Write(fib2 + " ");
    }

    for (int i = 0; i < n - 2; i++) {   
        sum = fib1 + fib2;              // 1  1  2  3  5  8
        Console.Write(sum + " ");       // 1  1  2  3  5  8
        fib1 = fib2;                    // 0  1  1  2  3  ...
        fib2 = sum;                     // 1  1  2  3  5  ...
    }
}

int N = new Random().Next(1, 10);
Console.Write($"Усли N = {N} -> ");
writeFib(N);
