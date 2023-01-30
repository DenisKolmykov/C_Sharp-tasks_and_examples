/*
Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 

Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetAckFunction(int m, int n)
{
    while (m > 0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = GetAckFunction(m, n - 1);
        }
        m = m - 1;
    }
    return (n + 1);
}


Console.Clear();

int m = 3;
int n = 2;

if (((m >= 4 && (m + n) > 5)) || (m == 3 && n > 13))
{
    Console.WriteLine("!!! Время на обработку и вывод результата составит НЕСКОЛЬКО ДНЕЙ");
    Console.WriteLine("!!! Значение результата будет за границами разрешенного диапазона значений");
    Console.WriteLine("!!! Измените (необходимо уменьшить) исходные данные М и/или N");
}
else
{
    if ((m == 4 && n == 1) || (m == 5 && n == 0) || (m == 3 && n == 13))
    {
        Console.WriteLine("!!! Время на обработку и вывод результата составит не менее 10 секунд");
        Console.WriteLine("Подождите, идет подсчет....");
    }
    Console.WriteLine($"A({m},{n}) = {GetAckFunction(m, n)}");
}
Console.WriteLine();