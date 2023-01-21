// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string ConvertNumberToBinary(int num)
{
    string result = string.Empty;
    result = num % 2 + result;

    while (num >= 2)
    {
        num = num / 2;
        result = num % 2 + result;
    }
    return result;
}

Console.Clear();

Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine()!);


Console.WriteLine("Число " + number + " в двоичном виде = " + ConvertNumberToBinary(number));

Console.WriteLine();