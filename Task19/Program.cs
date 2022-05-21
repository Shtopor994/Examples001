/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да


Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
*/
Console.WriteLine("Введите число для проверки: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((number1 == 0) || (reverse(number1, 0) == number1));
Console.ReadKey(true);

 
int reverse(int number1, int number2)
{
    while (number1 > 0) 
    { 
        number2 = number2 * 10 + number1 % 10; number1 /= 10; 
    }
    return number2;
}