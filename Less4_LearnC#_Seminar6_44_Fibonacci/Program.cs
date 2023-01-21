// Задача 44
// не используя рекурсию вывести первые N чисел Фибоначчи

int[] FibonacciNumbers (int n)
{
    int []arr = new int[n];
    arr[0]=0;
    arr[1]=1;

    for (int i=2; i<n;i++)
    {
        arr[i]=arr[i-1]+arr[i-2];
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

Console.Clear();

Console.Write("Введите количество цифр Фибоначчи для вывода: ");
int n = int.Parse(Console.ReadLine()!);

int [] fibonacci = new int[n];
fibonacci=FibonacciNumbers(n);

PrintArray (fibonacci);

Console.WriteLine();