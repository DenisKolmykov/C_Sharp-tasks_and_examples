// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.  
// !!! код составлен с отступлением от условия "натуральной степени"
//     - есть проверка на отрицательную натуральную степень и на степень = 0

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void PrintAPowB(int[] numbers)
{
    double aPowB = numbers[0];
    
    if (numbers[1] == 0)
    {
        aPowB = 1;
    }
    
    else
    {
        for (int i = 1; i < Math.Abs(numbers[1]); i++)
        {
            aPowB = aPowB * numbers[0];
        }

        if (numbers[1] < 0)
        {
            aPowB = 1 / aPowB;
        }
    }

    Console.Write(aPowB);
}

Console.Clear();

Console.WriteLine("Введите через пробел: любое число А и его степень В: ");
var numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Console.Write($"Число {numbers[0]} в степени {numbers[1]} = ");
PrintAPowB(numbers);

Console.WriteLine();