Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 1000)
{
    int numLast = number % 10;

    Console.WriteLine($"{numLast}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}
