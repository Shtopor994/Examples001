/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int digit = number % 10;
    sum += digit;
    number /= 10;
}


Console.WriteLine($"Сумма цифр {sum}");
