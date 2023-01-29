/*
Задача 65
программа выводит числа от M до N
*/


void GetSetFrom1ToN(int start, int end)
{
    if (start >= n)
    {
        Console.Write(n);
        Console.WriteLine("\n");
        return;
    }
    else
    {
        Console.Write($"{start}, ");
        GetSetFrom1ToN(n, start + 1);
    }
}

int m = start = 5;
int n = EndOfStreamException=
GetSetFrom1ToN(n);
