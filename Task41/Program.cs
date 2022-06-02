/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


void FillArray(int[] collection)
{
    Console.WriteLine("Введите Ваши числа:");
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
    }
}

int[] array = new int[5];
FillArray(array);
void PrintArray(int[] array)
{
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
}

int positiveNumber(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int count = positiveNumber(array);

Console.WriteLine("Вы ввели числа:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Из них больше 0: {count}");

