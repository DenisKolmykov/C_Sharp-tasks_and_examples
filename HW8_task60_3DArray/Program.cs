/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[] CreateArrayOfTwoDigitNumbers()
{
    int[] arrayOfTwoDigitNumbers = new int[180]; // 180 = count of two-digit numbers from -99 to 99
    for (int i = 10; i < 100; i++)
    {
        arrayOfTwoDigitNumbers[i - 10] = -i;
        arrayOfTwoDigitNumbers[i - 10 + 180 / 2] = i;
    }
    var rnd = new Random();
    for (int j = 0; j < 180; j++) // mix elements in this array
    {
        int temp = arrayOfTwoDigitNumbers[j];
        int newIndex = rnd.Next(0, 180);
        arrayOfTwoDigitNumbers[j] = arrayOfTwoDigitNumbers[newIndex];
        arrayOfTwoDigitNumbers[newIndex] = temp;
    }
    return arrayOfTwoDigitNumbers;
}


bool Create3DArrayRnd(int row, int column, int z)
{
    bool result = true;
    if (row * column * z > 180)
    {
        result = false;
    }
    else
    {
        int[,,] array = new int[row, column, z];
        int[] newElementArray = CreateArrayOfTwoDigitNumbers();
        int m = 0; // index of ArrayOfTwoDigitNumbers

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    array[i, j, k] = newElementArray[m];
                    m++;
                }
            }
        }
        Print3DArray(array);
    }
    return result;
}

void Print3DArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k],3} ({i},{j},{k}){"",-2}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.Clear();

int row = 3;
int column = 3;
int z = 3;

bool result = Create3DArrayRnd(row, column, z);
if (result == false)
{
    Console.WriteLine("!!! The size of 3D array more then possible diferent two-digit numbers (180)\n");
}

