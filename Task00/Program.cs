// 1. На вход принимает число
// 2. выдает его квадрат ( число умноженное на само себя)

//string input = Console.ReadLine();
//int number = Convert.ToInt32(input)

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

 Console.WriteLine($"Квадрат числа {number} ={square}");

