int randomNumber = new Random().Next(10, 100);

int numberOne = randomNumber % 10;
int numberTwo = randomNumber / 10;
Console.Write($"У Числа {randomNumber} ,большая цифра ");
if (numberOne > numberTwo)
{
    Console.Write(numberOne);
}
else
{
    Console.Write(numberTwo);
}