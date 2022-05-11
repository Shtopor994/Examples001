Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int temp = number - 1;

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if (i < temp)
        Console.Write(", ");
    }

}
