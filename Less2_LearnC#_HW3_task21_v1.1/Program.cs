// Задача 21(поочередный ввод координат)
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

void PrintDistanceT1T2(double[] coord)
{
    double distance = Math.Sqrt((coord[0] - coord[3]) * (coord[0] - coord[3]) + (coord[1] - coord[4]) * (coord[1] - coord[4]) + (coord[2] - coord[5]) * (coord[2] - coord[5]));
    Console.WriteLine($"Расстояние между точками Т1 ({coord[0]}; {coord[1]}; {coord[2]}) и Т2 ({coord[3]}; {coord[4]}; {coord[5]})");
    Console.WriteLine($"составляет {distance:f}");
}

double ParseCoordinates(int dot, int m)
{
    string c = "";

    double[] coordinates = new double[6];
    if (m == 0 | m == 3)
    {
        c = "x";
    }
    if (m == 1 | m == 4)
    {
        c = "y";
    }
    if (m == 2 | m == 5)
    {
        c = "z";
    }

    Console.Write($"{c}{dot}: ");
    coordinates[m] = double.Parse(Console.ReadLine()!);

    return coordinates[m];
}

int i = 1;
int k = 1;
int m = 0;
double[] coord = new double[6];

Console.Clear();

for (i = 1; i <= 2; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Введите координаты точки Т{i} (x,y,z): ");
    for (k = 1; k <= 3; k++)
    {
        coord[m] = ParseCoordinates(i, m);
        m++;
    }
}

Console.WriteLine();

PrintDistanceT1T2(coord);

Console.WriteLine();