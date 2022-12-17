// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел (и минимальное)

start:

Console.Clear();

int N = 3; // задаем количество чисел для сравнения
int[] numbers = new int[N]; // задаем массив в котором будем хранить числа для сравнения
int numberRange;
int i = 0; // переменная счетчика цикла

Console.WriteLine($"Программа для сравнения {N} чисел и определения из них наибольшего и наименьшего.");

Console.WriteLine("Вы введете числа сами (1) или сгенерировать их случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);
// проверять на коректность ввода не будем

if (choice == 1)
{
    while (i < N)
    {
        Console.Write($"Введите {i + 1} число для сравнения: ");
        numbers[i] = int.Parse(Console.ReadLine()!);
        i++;
    }
}

if (choice == 2)
{
    Console.WriteLine($"Будет сгенерировано {N} чисел из заданного диапазона (от -N до N)");
    Console.Write("Введите число N для задания диапазона: ");
    numberRange = int.Parse(Console.ReadLine()!);

    while (i < N)
    {
        numbers[i] = new Random().Next(-numberRange, numberRange + 1);
        Console.WriteLine($"Сгенерировано {i + 1} случайное число: {numbers[i]}");
        i++;
    }
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}

int max = numbers[0];
int min = numbers[0];

i = 0;

Console.Write($"Из чисел: ");

while (i < N)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    
    Console.Write(numbers[i]+ ", ");
    
    i++;

}

Console.WriteLine(" ");
Console.WriteLine($"наибольшее число = {max}, наименьшее число = {min}");

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