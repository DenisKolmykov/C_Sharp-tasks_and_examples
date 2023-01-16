// Задача 21 (ввод координат в одну строку)
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

void PrintDistanceT1T2(double[] arrT1, double[] arrT2)
{
    double distance = Math.Sqrt((arrT2[0] - arrT1[0]) * (arrT2[0] - arrT1[0]) + (arrT2[1] - arrT1[1]) * (arrT2[1] - arrT1[1]) + (arrT2[2] - arrT1[2]) * (arrT2[2] - arrT1[2]));
    Console.WriteLine($"Расстояние между точками Т1 ({arrT1[0]}; {arrT1[1]}; {arrT1[2]}) и Т2 ({arrT2[0]}; {arrT2[1]}; {arrT2[2]})");
    Console.WriteLine($"составляет {distance:f}");
}

Console.Clear();

Console.WriteLine("Введите черрез пробел координаты точки Т1 (x,y,z): ");
var CoordinatesOfPointT1 = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

Console.WriteLine();

Console.WriteLine("Введите через пробел координаты точки Т2 (x,y,z): ");
var CoordinatesOfPointT2 = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

Console.WriteLine();

PrintDistanceT1T2(CoordinatesOfPointT1,CoordinatesOfPointT2);

Console.WriteLine();
