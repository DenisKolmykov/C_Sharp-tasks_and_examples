/*
Задача 65
программа выводит числа от M до N
*/

void GetSetFrom1ToN(int start, int end)
{

    if (start == end)
    {
        Console.Write(end);
        Console.WriteLine("\n");
        return;
    }
    Console.Write($"{start}, ");
    GetSetFrom1ToN(start + 1, end);
}


int m = 5;
int n = 8;

int max = m;
int min = n;

if (m < n)
{
    max = n;
    min = m;
}
GetSetFrom1ToN(min, max);
