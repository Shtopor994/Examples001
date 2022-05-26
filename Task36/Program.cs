/* 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-10, 99);
    }
}

int[] array = new int[8];
FillArray(array);
void PrintArray(int[] array)
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

int sumOfNumber(int[] array1)
{
    int sum = 0;
    for (int i = 1; i < array1.Length; i = i + 2)
    {
        sum += array[i];

    }
    return sum;
}
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма нечетных индексов: ");
int sum = sumOfNumber(array);
Console.WriteLine($"{sum}");


