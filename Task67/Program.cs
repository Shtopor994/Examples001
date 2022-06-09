/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

/*
int digitsSum(int number)
    {
        if(number==0) return 0;
        return number % 10 + digitsSum(number/10);
    }

Console.WriteLine(digitsSum(453));
*/

void NaturalNumbersMN(int number, int summ=0)
{
    if (number == 0)
    {
        System.Console.WriteLine(summ);
    }
    if (number != 0)
    {
        summ = number % 10 + summ;
        number = number / 10;
        NaturalNumbersMN(number, summ);
    }
}
NaturalNumbersMN(45);

