// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
string input = Console.ReadLine();
int Number = int.Parse(input);
if (Number > 1)
{
   for (int i = 1; i <= Number; i++)
    {
        Console.WriteLine($"{i}*{i}*{i} = {i*i*i}");
    }
}
else
{
    Console.WriteLine("Данные для таблицы отсутствуют ");
}