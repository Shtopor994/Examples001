Console.Write("Введите два числа: ");


int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

