/* 
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] getRandomArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (var i = 0; i < rowNumber; i++)
    {
        for (var j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (var i = 0; i < arrayToPrint.GetLongLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.WriteLine($"[" + i + "]\t");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] randomArray = getRandomArray(10, 5, 10);
print2DArray(randomArray);