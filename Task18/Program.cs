/*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/



Console.WriteLine("Введите любую четверть от 1 до 4");
sbyte Number = Convert.ToSByte(Console.ReadLine());
if (Number == 1)
{
Console.WriteLine("Диапазон возможных координат точек X > 0 Y > 0");
}
else if (Number == 2)
{
Console.WriteLine("Диапазон возможных координат точек X < 0 Y > 0");
}
else if (Number == 3)
{
Console.WriteLine("Диапазон возможных координат точек X < 0 Y < 0");
}
else if (Number == 4)
{
Console.WriteLine("Диапазон возможных координат точек X > 0 Y < 0");
}
else
{
    Console.WriteLine("Ошибка ввода, повторите попытку");
}
