// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] InterCoefficientsOfEquation()
{
    double[,] line = new double[2, 2];

    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine("Для " + (i + 1) + "-го уравнения: y = k" + (i + 1) + " * x + " + "b" + (i + 1) + " введите: ");

        for (int j = 0; j < 2; j++)
        {
            if (j == 0)
            {
                Console.Write("значение k" + (i + 1) + "= ");
                line[i, j] = double.Parse(Console.ReadLine()!);
            }
            else
            {
                Console.Write("значение b" + (i + 1) + "= ");
                line[i, j] = double.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine();
    }

    return line;
}

void PrintEquations(double[,] line)
{
    for (int i = 0; i < line.GetLength(0); i++)
    {
        Console.WriteLine((i + 1) + "-я прямая задана уравнением: y = " + line[i, 0] + "x + " + line[i, 1]);
    }

}

double[] GetIntersectionPoint(double[,] lines)
// k1 * x + b1= k2 * x + b2; k1x-k2x = b2-b1; x(k1-k2) = b2-b1; 
// x = (b2-b1)/(k1-k2)
// b2 = lines[1, 1]
// b1 = lines[0, 1]
// k1 = lines[0, 0]
// k2 = lines[1, 0]

{
    double[] intersectionPoint = new double[2];

    double x = intersectionPoint[0] = (lines[1, 1] - lines[0, 1]) / (lines[0, 0] - lines[1, 0]);
    double y = intersectionPoint[1] = lines[0, 0] * x + lines[0, 1];

    return intersectionPoint;
}

//////////

Console.Clear();

double[,] lines = new double[2, 2];
lines = InterCoefficientsOfEquation();

PrintEquations(lines);

Console.WriteLine();

if (lines[0, 0] == lines[1, 0] & lines[0, 1] == lines[1, 1])
{
    Console.WriteLine("Указанные прямые - СОВПАДАЮТ (все точки одинаковые).");
}
else if (lines[0, 0] == lines[1, 0]) // проверка на параллельные прямые (k1 = k2)

{
    Console.WriteLine("Указанные прямые - ПАРАЛЛЕЛЬНЫ (не пересекаются).");
}
else 
{
    double[] intersectionPoint = GetIntersectionPoint(lines);
    Console.WriteLine($"Точка пересечения указанных прямых имеет координаты (x,y): ({intersectionPoint[0]:f2}; {intersectionPoint[1]:f2})");  
}
Console.WriteLine();

