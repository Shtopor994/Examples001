/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 99 & numberA < 1000)
{
    int numberOne = numberA / 100;
    int numberTwo = (numberA - numberOne * 100) / 10;
    int numberThree = numberA - numberOne * 100 - numberTwo * 10;
    Console.Write(numberTwo);
}
else
{
    Console.Write("Сэр, проверьте введенное число");
}

