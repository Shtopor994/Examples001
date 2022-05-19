/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int GetMultiOfSeries(int from, int to)
{
    int result = 1;
    for (var i = from; i <= to; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int multiOfSeries = GetMultiOfSeries(1, number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiOfSeries}");


