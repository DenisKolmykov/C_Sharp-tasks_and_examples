/*
Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSumFromMToN(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    int sum = n + GetSumFromMToN(m, n - 1);
    return sum;
}


int m = 1;
int n = 15;

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

Console.WriteLine(GetSumFromMToN(m, n));
