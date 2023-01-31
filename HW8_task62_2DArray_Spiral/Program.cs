/*
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] Create2DArraySpiral(int m, int n)
{
    int[,] array = new int[m, n];

    n = n - 1;
    m = m - 1;

    int finishCount = 0; // number of passes "i" from array size
    if (m >= n) finishCount = n / 2;
    else finishCount = m / 2;

    array[0, 0] = 1;
    int row = 0;
    int column = 0;

    int startRow = 0;
    int startColumn = 1;
    int finishRow = m;
    int finishColumn = n;

    int start = startColumn; // start from [0,1] clockwise
    int finish = 0;

    bool rowOrCol = true;  // passes to: true = rows, false = columns
    bool direction = true; // passes direction true = forvard (>), false = revers (<)

    for (int i = 1; i <= finishCount + 1; i++)
    {
        // passes >>>
        row = i - 1;
        finish = finishColumn = n - i + 1;
        rowOrCol = false;
        direction = true;
        array = FillPartOfArray(rowOrCol, direction, array, row, column, start, finish);

        // passes |>
        column = n - i + 1;
        start = startRow = i;
        finish = finishRow = m - i + 1;
        rowOrCol = true;
        direction = true;
        array = FillPartOfArray(rowOrCol, direction, array, row, column, start, finish);

        // passes <<<
        row = m - i + 1;
        start = startColumn = i - 1;
        finish = finishColumn = n - i; //
        rowOrCol = false;
        direction = false;
        array = FillPartOfArray(rowOrCol, direction, array, row, column, start, finish);

        // passes <|
        column = i - 1;
        start = startRow = i;
        finish = finishRow = m - i;
        rowOrCol = true;
        direction = false;
        array = FillPartOfArray(rowOrCol, direction, array, row, column, start, finish);

        start = startColumn = i;
    }
    return array;
}

int[,] FillPartOfArray(bool rowOrCol, bool direction, int[,] array, int row, int column, int start, int finish)
{
    int r = 0; // these "r" and "c" variables are needed for get the previous value from array
    int c = 0;

    if (direction)
    { // cycle for forvard (>>>) direction
        for (int vector = start; vector <= finish; vector++) // vector - is may be "row" or "column"
        {                                                    // it is needed in cycle to assign the changing elem in array            
            if (rowOrCol)
            {
                row = vector;
                r = 1;
                c = 0;
            }
            else
            {
                column = vector;
                r = 0;
                c = 1;
            }

            if (array[row, column] != 0) break; // ovewwrite protection:
                                                // stop filling the array if in this index value > 0 (already written early)
            array[row, column] = array[row - r, column - c] + 1;
        }
        return array;
    }
    else
    { // cycle for reverse (<<<) direction
        for (int vector = finish; vector >= start; vector--)
        {
            if (rowOrCol)
            {
                row = vector;
                r = 1;
                c = 0;
            }
            else
            {
                column = vector;
                r = 0;
                c = 1;
            }

            if (array[row, column] != 0) break;

            array[row, column] = array[row + r, column + c] + 1;
        }

        return array;
    }
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write($"0{arr[i, j],-3}");
            }
            else
            {
                Console.Write($"{arr[i, j],-4}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int m = 11; // Array m x n
int n = 7;

int[,] array = Create2DArraySpiral(m, n);

Print2DArray(array);
