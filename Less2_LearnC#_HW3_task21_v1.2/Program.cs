// Задача 21(поочередный ввод координат)
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

void PrintDistanceT1T2(double[,] coord)
{
    int i =0; // счетчик цикла
    double distance =0;

    for (i=0; i<3; i++)
    {
    distance = distance + Math.Sqrt((coord[0,0] - coord[1,0]) * (coord[0,0] - coord[1,0]); 
    
    //+ (coord[0,1] - coord[1,1]) * (coord[0,1] - coord[1,1]) + (coord[0,2] - coord[1,2]) * (coord[0,2] - coord[1,2]));
    
    Console.WriteLine($"Расстояние между точками Т1 ({coord[0,0]}; {coord[0,1]}; {coord[0,2]}) и Т2 ({coord[1,0]}; {coord[1,1]}; {coord[1,2]})");
    Console.WriteLine($"составляет {distance:f}");
}

int d = 0; // переменная индекса двумерного массива - строки (точки)
int c = 0; // переменная индекса двумерного массива - столбцы (координаты)

string[] coordName = { "x", "y", "z" }; // массив названия координат для отображения при вводе
double[,] coord = new double[2, 3]; // двумерный массив координат: две строки - точка 1 и 2; 3 столбца - координаты x,y,z

Console.Clear();

for (d = 0; d < 2; d++)
{
    Console.WriteLine();
    Console.WriteLine($"Введите координаты точки Т{d+1} (x,y,z): ");
    for (c = 0; c < 3; c++) 
    {
        Console.Write($"{coordName[c]}{d+1}: "); //выводим название координаты для ввода соотв значения
        coord[d, c] = double.Parse(Console.ReadLine()!); // записываем в массив значение введенной координаты по соответствующей точке
    }
}

Console.WriteLine();

PrintDistanceT1T2(coord);

Console.WriteLine();
