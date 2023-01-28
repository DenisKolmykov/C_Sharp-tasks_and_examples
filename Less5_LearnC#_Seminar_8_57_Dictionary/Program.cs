// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


int[,] Create2DArrayRnd(int row, int collumns, int minValue, int maxValue)
{
    int[,] array = new int[row, collumns];
    var rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
        }
        Console.WriteLine();
    }
}

int CountNumber(int[,] array, int number, int minValue)
{
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                count++;
                array[i, j] = minValue - 1; // idea: when we find each repeated element, we change it  
            }                               // to (minValue - 1) - the value that is guaranteed not to be presented in tha array
                                            // This is necessary so as not to check and count elements, that have been counted before
        }
    }

    return count;
}

void Dictionary(int[,] array, int minValue)
{
    int number = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > minValue - 1) // we do not check elements, that already been counted
            {
                number = array[i, j];
                int count = CountNumber(array, number, minValue);
                Console.WriteLine("For element = " + number + "; count = " + count);
            }

        }
    }
    Console.WriteLine();
}


int row = 5;
int column = 5;

int minValue = 0;
int maxValue = 10;

int[,] arrayForCount = Create2DArrayRnd(row, column, minValue, maxValue);
Print2DArray(arrayForCount);
Console.WriteLine();

Dictionary(arrayForCount, minValue);