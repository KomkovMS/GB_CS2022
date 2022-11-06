/*
27. Определить количество цифр в числе
*/


// 1 способ - рекурсией
int GetDigits(int number)
{
    if (number < 10) return 1;
    return 1 + GetDigits(number / 10); 
}

int number = 820;
int digits = GetDigits(number);
Console.WriteLine(digits);


// 2 способ - циклом

Console.WriteLine("----------------");

int GetDig(int num)
{
    int count = 0;
    
    if (num == 0) return 1;
    else
    {
        while (num > 0)
        {
            num /= 10;
            count++;
        }

        return count;
    }   
}


int num = 82;
int digit = GetDig(num);
Console.WriteLine(digit);

