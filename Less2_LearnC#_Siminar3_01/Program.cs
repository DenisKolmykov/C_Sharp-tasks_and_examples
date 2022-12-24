// при указании номера четверти
// программа выводит диапазон возможных значений координат 

void PrintXYFromQuarter(int q)
{
    if (q == 1)
    {
        // int x = new Random().Next(1, int.MaxValue);
        // int y = new Random().Next(1, int.MaxValue);
        Console.WriteLine($"Диапазон возможных значенией при X > 0 и У > 0 ");
    }
    else if (q == 2)
    {
        // int x = new Random().Next(1, int.MaxValue);
        // int y = new Random().Next(-1, int.MinValue);
        Console.WriteLine($"Диапазон возможных значенией при X > 0 и У < 0 ");
    }

    else if (q == 3)
    {
        //int x = new Random().Next(-1, int.MinValue);
        //int y = new Random().Next(-1, int.MinValue);
        Console.WriteLine($"Диапазон возможных значенией при X < 0 и У < 0 ");
    }
    else if (q == 4)
    {
        // int x = new Random().Next(-1, int.MaxValue);
        // int y = new Random().Next(1, int.MaxValue);
        Console.WriteLine($"Диапазон возможных значенией при X < 0 и У > 0 ");
    }
}
    // int quarter = 1;
    
    Console.Clear();
    
    Console.Write("Введите номер четверти от 1 до 4: ");
    int quarter = int.Parse(Console.ReadLine()!);
    PrintXYFromQuarter(quarter);