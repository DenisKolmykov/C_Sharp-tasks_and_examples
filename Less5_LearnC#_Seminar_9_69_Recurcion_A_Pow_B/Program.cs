/*
Задача 69: 
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


int APowB(int a, int b)
{
    if (b == 1)
    {
        return a;
    }

    int pow = a * APowB(a, b - 1);
    return pow;
}


int a = 3;
int b = 5;

Console.WriteLine(APowB(a, b));