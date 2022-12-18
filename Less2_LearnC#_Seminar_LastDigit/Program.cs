// 2. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int GetLastDigit(int num)
{
    return num % 10;
}

int num;
int lastDigit;

Console.Clear();
Console.WriteLine("Программа показывает последнюю цифру трехзначного числа. ");
Console.WriteLine();
Console.Write("Введите трехзначное число: ");
num = int.Parse(Console.ReadLine()!);
if (num < 1000 & num > 99)
{
    lastDigit = GetLastDigit(num);
    Console.WriteLine($"Последняя цифра от введенного числа {num} будет = {lastDigit}.");
}
else Console.WriteLine("Вы ввели не трехзначное число");