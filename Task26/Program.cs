/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetNumberOfDigit (int number)
{
    int i = 0;
    for (i = 0; i <= number; i++)
    {
        number = number / 10;
    }
    return i;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfDigit = GetNumberOfDigit(number);
Console.WriteLine($"{number} - > {numberOfDigit}");



