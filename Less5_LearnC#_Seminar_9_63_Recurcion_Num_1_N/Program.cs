/*
Задача №63
программа выводит числа от 1 до N
*/


void GetSetFrom1ToN(int n, int start = 1)
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
        GetSetFrom1ToN(n,start + 1);
    }
}

int n = 10;
GetSetFrom1ToN(n);
