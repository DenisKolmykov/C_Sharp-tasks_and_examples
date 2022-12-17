// Задача 2: 
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

int N = 2; // задаем количество чисел для сравнения
int numberA=0, numberB=0, numberRange;
int max=0, min=0;

Console.WriteLine($"Программа для сравнения {N} чисел и определения из них наибольшего и наименьшего.");

Console.WriteLine("Вы введете числа сами (1) или сгенерировать их случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);
// проверять на коректность ввода не будем

if (choice == 1)
    {
    Console.Write("Введите первое число для сравнения: ");
    numberA = int.Parse(Console.ReadLine()!);
        
    Console.Write("Введите второе число для сравнения: ");
    numberB = int.Parse(Console.ReadLine()!);
    }

if (choice == 2)
    {
    Console.WriteLine("Будет сгенерировано два числа из заданного диапазона (от -N до N)");
    Console.Write("Введите число N для задания диапазона: ");
    numberRange = int.Parse(Console.ReadLine()!);
    
    numberA = new Random().Next(-numberRange, numberRange+1);
    Console.WriteLine ($"Сгенерировано первое случайное число: {numberA}");
    
    numberB = new Random().Next(-numberRange, numberRange+1);
    Console.WriteLine ($"Сгенерировано второе случайное число: {numberB}");
    }

if (choice <1 |choice > 2)
    {
    Console.WriteLine ("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
    }

if (numberA > numberB)
    {
    max = numberA;
    min = numberB;
    }
if (numberA < numberB) 
    {
    max = numberB;
    min = numberA;
    }
if  (numberA == numberB)
    {
    Console.WriteLine ($"Числа {numberA} и {numberB} равны между собой.");
    goto end;
    }

Console.WriteLine ($"из двух чисел {numberA} и {numberB}");
Console.WriteLine ($"наибольшее число = {max}, наименьшее число = {min}");

end:;