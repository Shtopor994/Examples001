/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.WriteLine("Введите порядковый номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 0 & numberA <= 5)
{
    Console.WriteLine("Это будний день");
}
else if (numberA == 6 || numberA == 7)
{
    Console.WriteLine("Выходной");
}