Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Квадрат числа {b} ={a} -> Да");
}
else
{
    Console.WriteLine($"Квадрат числа {b} не равняется {a} -> Нет ");
}


