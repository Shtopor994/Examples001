/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

Console.WriteLine("Введите координаты точки А");

Console.WriteLine("Введите координаты Х точки А");
int XpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки А");
int YpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки А");
int ZpointA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B");

Console.WriteLine("Введите координаты Х точки B");
int XpointB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B");
int YpointB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки B");
int ZpointB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((XpointB - XpointA) * (XpointB - XpointA) + (YpointB - YpointA) * (YpointB - YpointA) + (ZpointB - ZpointA) * (ZpointB - ZpointA));

Console.WriteLine($"Расстояние между точками А и В {Math.Round(distance,2)}");
