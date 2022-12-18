// Задача №2 из семинара
// Напишите программу, которая выводит случайное трехзначное число (может быть применимо к любому)
// и удаляет вторую (любую выбранную) цифру этого числа

start:

void PrintNumberWithouyDigit(int digits, int num, int deleteDigit)
{
    int i = 0; //  счетчик цикла
    int numDigit = num;
    Console.WriteLine($"Указанное {digits}х-значное число {num} без {deleteDigit}-го разряда будет = ");

    int[] numberDigits = new int[digits]; // сюда записываем цифры, из которых состоит число

    while (i < digits)
    {
        int j = Convert.ToInt32(Math.Pow(10, digits - i - 1));
        numberDigits[i] = numDigit / j;
        numDigit = numDigit % j;

        if (i + 1 == deleteDigit)
            i++;
        else
        {
            Console.Write(numberDigits[i]);
            i++;
        }

    }

}


int number = 0;
int digits = 3; // разрядность числа
int deleteDigit = 0; // порядковый номер цифры для "удаления" из числа

Console.Clear();

Console.WriteLine("Данная программа удаляет цифру из указанного разряда числа.");
Console.WriteLine();
Console.WriteLine($"Вы введете {digits}-х значное число сами (1) или сгенерировать его случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (choice == 1)
{
    Console.Write("Введите число: ");
    number = int.Parse(Console.ReadLine()!);
    // можно (но здесь не будем) отдельной функцией проверить соответвие разрядности введенного числа
}

if (choice == 2)
{
    number = new Random().Next(100, 1000);
    Console.WriteLine($"Из диапазона от 100 до 1000 сгенерировано случайное число: {number}");
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}
start2:
Console.Write("Введите порядковый номер разряда, который будет удален: ");
deleteDigit = int.Parse(Console.ReadLine()!);

if (deleteDigit < 1 || deleteDigit > digits)
{
    Console.WriteLine("Вы ввели для удаления разряд, не соответствующий разрядности числа.");
    Console.WriteLine("Повторить ввод (y) или выйти (любая клавиша)?: ");
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