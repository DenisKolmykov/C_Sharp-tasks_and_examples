// Задача №2 из семинара
// Напишите программу, которая выводит случайное трехзначное число (может быть применимо к любому)
// и удаляет вторую (любую выбранную) цифру этого числа

start:
int GetDigitsOfNumber(int num)
{
    // делим на 10^2 - если  результат = 0 то норм
    // делим на 10^3 - если результат = 0 то норм
    // и так далее...

    int digits = 0;
    int i = 2; // счетчик цикла
    
    while (i <= 10)
    {
        if (num / Convert.ToInt64(Math.Pow(10, i)) == 0) 
        {
            digits = i;
            break;
        }

        else i++;
    }
    return digits;
}

void PrintNumberWithouyDigit(int digits, int num, int deleteDigit)
{
    // например (digits =5) 
    // например number = 76543 = 3 + 4*10 + 5*100 + 6*1000 + 7*10000
    // number = 3 + 4*10^1 + 5*10^2 + 6*10^3 + 7*10^4
    // 3 = остаток number от деления на 10^1
    // 4 = остаток number от деления на 10^2 и результат делим на 10^1
    // 5 = остаток number от деления на 10^3 и результат делим на 10^2
    // 6 = остаток number от деления на 10^4 и результат делим на 10^3
    // 7 = остаток number от деления на 10^5 и результат делим на 10^4
    // например deleteDigit = 4 (проверка, что deleteDigit >=1 и меньше digits)
    // numberWithoutDeleteDigit = (number / 10^(digits - deleteDigit + 1)) * 10^(digits-deleteDigit) + number%(10^(digits - deleteDigit))
  
    // определяем какая цифра находится на позиции удаления
    int deleteDigitNumber = (num % Convert.ToInt32(Math.Pow(10,(digits - deleteDigit + 1))))/Convert.ToInt32(Math.Pow(10,(digits - deleteDigit)));
    
    Console.WriteLine ($"На {deleteDigit}-м месте в указанном числе находится цифра {deleteDigitNumber}.");
    Console.WriteLine();
   
   // вычисляем какое получится число после удаления цифры из указанного мкста
    int numberWithoutDeleteDigit = (num / Convert.ToInt32(Math.Pow(10, (digits - deleteDigit + 1)))) * Convert.ToInt32(Math.Pow(10, (digits - deleteDigit))) + num % (Convert.ToInt32(Math.Pow(10, (digits - deleteDigit))));
    
    Console.WriteLine($"Указанное {digits}х-значное число {num} без {deleteDigit}-й цифры будет = {numberWithoutDeleteDigit}");
}


int number = 0;
int digits = 0; // разрядность числа
int deleteDigit = 0; // порядковый номер цифры для "удаления" из числа

Console.Clear();

Console.WriteLine("Данная программа удаляет цифру из указанного разряда числа.");
Console.WriteLine();
Console.WriteLine($"Вы введете любое число сами (1) или сгенерировать его случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (choice == 1)
{
    Console.Write("Введите число не менее 10 и не более MaxValue (2 147 483 647): ");
    number = int.Parse(Console.ReadLine()!);
    if (number < 10) 
    // || number > 2147483647) первоначально в условия добавлял проверку на "или больше мах"
    // но при вводе числа больше Max.Value система тсама останавливает выполнене программы
    {
        Console.WriteLine("Введенное Вами число за рамками указанного диапазона.");
        goto end;
    }
}

if (choice == 2)
{
    number = new Random().Next(10, int.MaxValue);
    Console.WriteLine($"Из диапазона от 10 до MaxValue (2 147 483 647)");
    Console.WriteLine($"сгенерировано случайное число: {number}");
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}
start2:
// сюда вставим результат функции по подсчету количества разрядов опредлеение digits
digits = GetDigitsOfNumber(number);

Console.WriteLine($"Введенное число состоит из {digits} цифр");
Console.WriteLine();
Console.Write("Введите позицию цифры (слева-направо), которая будет удалена: ");
deleteDigit = int.Parse(Console.ReadLine()!);

if (deleteDigit < 1 || deleteDigit > digits)
{
    Console.WriteLine("Вы ввели для удаления позицию, не соответствуюуюй разрядности числа.");
    Console.Write("Повторить ввод (y) или выйти (любая клавиша)?: ");
    string str2 = Console.ReadLine()!;
    if (str2.ToLower() == "y")
    {
        goto start2;
    }
    else goto end;
}

PrintNumberWithouyDigit(digits, number, deleteDigit);


end:;
Console.WriteLine();
Console.WriteLine("Продолжить работу с программой или выход?");
Console.Write("Ваш выбор (ведите Y-для продолжения или любой другой для выхода): ");
string str = Console.ReadLine()!;
if (str.ToLower() == "y")
{
    goto start;
}
else
{
    Console.Clear();
    Console.WriteLine("Спасибо за использование праграммы!");
    Console.WriteLine("До новых встреч!");
    Console.WriteLine();
}
