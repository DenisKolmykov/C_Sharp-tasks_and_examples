// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

start:

Console.Clear();

int numberA = 0, numberRange;
int i = 2; // счетчик цикла
int j = 0; // счетчтк количества четных чисел

Console.WriteLine("Данная программа выявляет все четные числа в диапазоне от 1 до N.");

Console.WriteLine("Вы введете число N сами (1) или сгенерировать их случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);
// проверять на коректность ввода не будем

if (choice == 1)
{
    Console.Write("Введите число: ");
    numberA = int.Parse(Console.ReadLine()!);
    if (numberA <= 0)
    {
        Console.WriteLine("!Необходимо ввести целое неотрицательное число!");
        goto end;
    }
}

if (choice == 2)
{
    Console.WriteLine("Будет случайным образом сгенерировано число из заданного диапазона (от 1 до N)");
    Console.Write("Введите число N для задания диапазона: ");
    numberRange = int.Parse(Console.ReadLine()!);

    numberA = new Random().Next(1, numberRange + 1);
    Console.WriteLine($"Сгенерировано случайное число: {numberA}");
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}

if (numberA == 1)
    {
       Console.WriteLine ("В указанном диапазоне ЧЕТНЫЕ числа отсутствуют");
       goto end;
    }

Console.WriteLine($"В диапазоне от 1 до {numberA} присутствуют следующие четные числа: ");

while (i <= numberA)
{
    if (i % 2 == 0)
    {
        Console.Write($" {i}, ");
        j = j + 1;
    }

    i = i + 1;
}
Console.WriteLine(" ");
Console.WriteLine($"всего количество четных чисел = {j}.");

end:;
Console.WriteLine("Продолжить работу с программой или выход?");
Console.Write("Ваш выбор (ведите Y-для продолжения или любой другой для выхода): ");
string str = Console.ReadLine()!;
if (str.ToLower() == "y")
{
    goto start;
}
else
{
    Console.WriteLine("Спасибо за использование праграммы!");
    Console.WriteLine("До новых встреч!");
}