// Задача 59
// задайте 2D массив из целых чисел
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименший элемент массива



int[,] Create2DArrayRnd(int row, int collumns, int minValue = 0, int maxValue = 100)
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
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[] FindIndexOfMinElement(int[,] array)
{
    int[] indexOfMinElement = new int[2];
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                indexOfMinElement[0] = i;
                indexOfMinElement[1] = j;
                min = array[i, j];          // Memory and WriteOut only for checking
            }
        }
    }
    Console.WriteLine("min = " + min + " (" + indexOfMinElement[0] + "," + indexOfMinElement[1] + ")"); //WriteOut only for checking

    return indexOfMinElement;
}

int[,] DeleteRowColumnOfMinAndCreateNewArr(int[,] array, int[] indexOfMinElement)
{
    int[,] newArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int deleteRow = indexOfMinElement[0];
    int deleteColumn = indexOfMinElement[1];

    int rowNewArr = 0;
    int i = 0;
    while (i < array.GetLength(0))
    {
        if (i != deleteRow && rowNewArr < array.GetLength(0) - 1)
        {
            int j = 0;
            int columnNewArr = 0;

            while (j < array.GetLength(1))

            {
                if (j != deleteColumn && columnNewArr < array.GetLength(1) - 1)
                {
                    newArr[rowNewArr, columnNewArr] = array[i, j];
                    columnNewArr++;
                }
                j++;
            }
            rowNewArr++;
        }
        i++;
    }
    return newArr;
}

Console.Clear();

int row = 5;
int column = 6;

int[,] array = Create2DArrayRnd(row, column);
Print2DArray(array);
Console.WriteLine();

int[] indexOfMinElement = FindIndexOfMinElement(array);

int[,] newArray = DeleteRowColumnOfMinAndCreateNewArr(array, indexOfMinElement);

Print2DArray(newArray);
Console.WriteLine();
