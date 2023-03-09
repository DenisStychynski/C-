Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= number)
{
    if (number % 2 == 0)
    {
        
        Console.Write("Да");

    }
    if (number % 2 == 1)
    {
        
        Console.Write("Нет");

    }
        count++;

}
if (number == 1)
{

    Console.Write("нет");

}

if (number == 0)
{
    Console.Write("нет");


}
