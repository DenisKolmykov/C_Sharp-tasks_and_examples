// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void PrintPalindrom(int num) //  функция для оределения палиндрома
{
    int i = 0;

    string strNum = num.ToString(); // введенное пользователем число преобразуем в string
    int length = strNum.Length; // определяем длину строки (по-сути - кол-во разрядов числа num)
    
    char[] reverseCharNum = new char[length]; // сюда записываем каждую отдельную цифру разряда числа в обратном порядке

    while (i < length)
    {
        reverseCharNum[i] = strNum[length - i - 1]; // цифра с последнего места [последний индекс] - записывается на первое место [0]  и тд
        i++;
    }

    string reverseStrNum = new string(reverseCharNum); // преобразовываем массив с отдельными элементами - в строку

    int reverseNum = Int32.Parse(reverseStrNum); // преобразовываем строку - в число

    Console.WriteLine();
    Console.WriteLine($"Обратная запись числа: {reverseNum}");
    
        if (num == reverseNum) // сравниваем введенное число num с его обратной записью
        {
            Console.WriteLine("Введенное Вами число ЯВЛЯЕТСЯ палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенное Вами число НЕ является палиндромом.");
        }
}

Console.Clear();

Console.Write("Введите любое целое число (int): ");
int number = int.Parse(Console.ReadLine()!);

PrintPalindrom(number);

Console.WriteLine();