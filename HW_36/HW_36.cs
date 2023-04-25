// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Lenght = PrintDigital("Введите длину массива ");
int[] array = RandomArray(Lenght);
PrintArray(array);
SumArray(array);

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
        array[i] = random.Next();
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

void SumArray(int[] array)
{
   int sum = 0;
   int i = 0;
   while (i < array.Length)
  {
    sum = sum + array[i];
    i = i+2;
  }
  Console.WriteLine(" Сумма всех элементов массива на нечетных позициях " + sum);
}
