// Программа выводит случайное число и находит наибольшую цифру в этом числе

int GetMaxDigit(int number)
{
    int maxDigit;
    int secondDigit = number % 10;
    int ferstDigit = number / 10;
    if (ferstDigit > secondDigit)
    {
        maxDigit = ferstDigit;
    }
    else maxDigit = secondDigit;
    return maxDigit;
}

int num;
int maxDigit;
num = new Random().Next(10, 100);
Console.WriteLine ($"Будем искать наибольшую цифру в числе {num}");
maxDigit = GetMaxDigit (num);
Console.WriteLine ($"Наибольшая цифра в числе {num} будет = {maxDigit}");