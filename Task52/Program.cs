/* 
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите размер матрицы:");
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int[,] matrix = new int[M, N];
Random rand = new Random();
int[] summ = new int[N];
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix[i, j] = rand.Next(0, 10); //рандомные значения для елементов матрицы

    }
}
Console.WriteLine("Матрица");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {

        Console.Write(matrix[i, j]); //вывод матрицы
        summ[i] += matrix[j, i];      //подсчет суммы колонки
    }
    Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{

    Console.WriteLine(elem / N); //вывод среднего для колонки
}