// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.  
// !!! код составлен с отступлением от условия "натуральной степени"
//     - есть проверка на отрицательную натуральную степень и на степень = 0

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void PrintAPowB(int a, int b)
{
    double aPowB = a;
    
    if (b == 0)
    {
        aPowB = 1;
    }
    
    else
    {
        for (int i = 1; i < Math.Abs(b); i++)
        {
            aPowB = aPowB * a;
        }

        if (b < 0)
        {
            aPowB = 1 / aPowB;
        }
    }

    Console.Write(aPowB);
}

Console.Clear();

Console.WriteLine("Введите через пробел: любое число А и его степень В: ");
var numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int a= numbers[0];
int b = numbers[1];

Console.Write($"Число {a} в степени {b} = ");
PrintAPowB(a,b);

Console.WriteLine();