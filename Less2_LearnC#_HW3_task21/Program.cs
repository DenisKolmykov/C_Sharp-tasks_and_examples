// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

void PrintDistanceT1T2(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine($"Расстояние между точками Т1 ({x1}; {y1}; {z1}) и Т2 ({x2}; {y2}; {z2})");
    Console.WriteLine($"составляет {distance:f}");
}

Console.Clear();

Console.WriteLine("Введите координаты точки Т1 (x,y,z): ");

Console.Write("x1 :");
double x1= double.Parse(Console.ReadLine()!);

Console.Write("y1 :");
double y1= double.Parse(Console.ReadLine()!);

Console.Write("z1 :");
double z1= double.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine("Введите координаты точки Т2 (x,y,z): ");

Console.Write("x2 :");
double x2= double.Parse(Console.ReadLine()!);

Console.Write("y2 :");
double y2= double.Parse(Console.ReadLine()!);

Console.Write("z2 :");
double z2= double.Parse(Console.ReadLine()!);

Console.WriteLine();

PrintDistanceT1T2(x1,y1,z1,x2,y2,z2);

Console.WriteLine();