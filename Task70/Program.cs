/*
Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 
*/



string UpToNumberPlus(int a, int b, int N)
{
    if (N == 0)
    {
        return " ";
    }
     else
     {
         return $"{a} " + UpToNumberPlus(b, a + b, N - 1);
     }
}
string result = UpToNumberPlus(3, 4, 5);
Console.WriteLine(result);