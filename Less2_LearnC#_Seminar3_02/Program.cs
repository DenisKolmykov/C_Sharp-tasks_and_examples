//  программа определяет расстояние между точками (координаты XY каждой точки) на 2D плоскости

void PrintDistanceT1T2(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
    Console.WriteLine($"Расстояние между точкой Т1 ({x1}, {y1}) и точкой Т2 ({x2}, {y2}) = {distance}");
}

int x1 = 7, y1 = -5;
int x2 = 1, y2 = -1;

PrintDistanceT1T2(x1, y1, x2, y2);