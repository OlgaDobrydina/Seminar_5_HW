// Напишите программу, которая приниматет на вход длину массива,
// минимальное значение массива и максимальное значение массива,
// создаёт массив с заданными параметрами и выводит значения на экран
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

int PrintDigital(string mes)
{
    Console.Write(mes);
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

int[] RandomArray(int Lenght, int minNumber, int maxNumber)
{ 
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minNumber, maxNumber + 1);
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

int Lenght = PrintDigital("Введите длину массива ");
int min = PrintDigital("Введите минимальный элемент ");
int max = PrintDigital("Введите максимальный элемент ");
int[] array = RandomArray(Lenght, min, max);
PrintArray(array);