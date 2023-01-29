/*
Задача 67: 
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumDigit(int n)
{
    if (n / 10 == 0)
    {
        return n;
    }

    int sum = n % 10 + SumDigit(n / 10);
    return sum;
}


int n = 123456;
Console.WriteLine(SumDigit(n));