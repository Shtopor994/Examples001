/* See https://aka.ms/new-console-template for more information
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

void printArray(int[] arrayToPrint)
{
    Console.WriteLine("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.WriteLine(arrayToPrint[i]);
        if (i != arrayToPrint.Length)
        {
            Console.WriteLine(", ");
        }
    }
    Console.WriteLine("]");
}
int sumElementsOfArray(int[] arrayToCalculate, int multiplay)
{
    int result = 0;
    for (int i = 0; i < arrayToCalculate.Length; i++)
    {
        if(arrayToCalculate[i] * multiplay > 0)
        {
        result += arrayToCalculate[i];
        }
    }
    return result;
}


int[] randomArray = getRandomArray(12,1);
int positiveSumOfArray = sumElementsOfArray(randomArray, 1);
int negativeSumOfArray = sumElementsOfArray(randomArray, -1);
printArray(randomArray);
Console.WriteLine($"сумма положительных элементов {positiveSumOfArray}, сумма отрицательных {negativeSumOfArray}");