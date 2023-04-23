// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите степень ");
int number2 = int.Parse(Console.ReadLine());
double sqrt = Math.Pow(number1, number2);
Console.WriteLine(sqrt);