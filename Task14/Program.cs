/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99)
{
 Console.WriteLine(numberA > 99 ? numberA.ToString()[2] : '-'); 
}

else
{
    Console.Write("Нет третьего числа");
}
