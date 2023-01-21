//Задача 40: 
//Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон


bool IsTriangle(int[] arr)
{
    int sum = 0;
    int len = arr.Length;
    bool possible = true;

    for (int i = 0; i < len; i++)
    {
        sum = sum + arr[i];
    }

    for (int i = 0; i < len; i++)
    {
        if (arr[i] > sum - arr[i])
        {
            possible = false;
            break;
        }
    }
return possible;

}

int[] parties = new int[] {1,2,7 };

if (IsTriangle(parties)) 
{
    Console.WriteLine("possible");
}
else Console.WriteLine("IMpossible");
