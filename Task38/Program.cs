/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(double[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-10, 99);
    }
}
double[] array = new double[8];
FillArray(array);
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length; j++)
    {
        if (j < array.Length - 1)
        {
            Console.Write($"{array[j]}, ");
        }
        else
        {
            Console.Write(array[j]);
            break;
        }
    }
    Console.Write("]");
}
double diffOfNumbers(double[] array1)
{
    double result = 0;
    for (int i = 0; i <= array1.Length; i++)
    {
        double min = array.Min();
        double max = array.Max();
        result = max - min;
    }
    return result;
}

Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine();
double result = diffOfNumbers(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {result}");
