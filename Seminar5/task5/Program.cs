/*
5. Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

*/

// мое решение :-((

// 


// решение на семинаре

int length = 5;
int[] newArr = new int[5]{1, 2, 3, 4, 5};
int resultLength = 0;

// если длина массива четная
if (length % 2 == 0) {
    resultLength = length / 2;
} else {
    resultLength = length / 2 + 1;
}

int[] result = new int[resultLength];

for (int i = 0; i < length / 2; i++) {
    result[i] = newArr[i] * newArr[length - i - 1];
}

// получение середины при нечетной длине
if (length % 2 != 0) {
    result[resultLength - 1] = newArr[length / 2];
}


// печать резульата
for (int i = 0; i < newArr.Length; i++) {
    Console.Write(newArr[i] + " ");
}

Console.Write("-> ");

for (int i = 0; i < resultLength; i++) {
    Console.Write(result[i] + " ");
}
