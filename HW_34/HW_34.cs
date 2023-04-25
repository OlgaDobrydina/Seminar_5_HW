// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Lenght = PrintDigital("Введите длину массива ");
int[] array = RandomArray(Lenght);
PrintArray(array);
PrintCount(array);

int PrintDigital(string mes)
{
    Console.Write(mes);
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

int[] RandomArray(int Lenght)
{ 
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 1000);
    }
    return array;   
} 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

void PrintCount(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length ; i++)
  {
    if (array[i] % 2 == 0)
    {
     count = count + 1;
    }
  }
  Console.WriteLine("Количество четных чисел " + count);
}