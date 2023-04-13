// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число ");
string input = Console.ReadLine();
int number1 = int.Parse(input);
Console.WriteLine("Ведите второе число ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

if (number1 > number2) Console.WriteLine("Первое число больше ");
else Console.WriteLine("Второе число больше ");