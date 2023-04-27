// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Lenght = PrintDigital("Введите длину массива ");
int[] array = RandomArray(Lenght);
PrintArray(array);
int min = MinDigital(array);
int max = MaxDigital(array);
RaznArray(min, max);

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
        array[i] = random.Next(1, 100);
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

int MaxDigital(int[] array)
{
    int maxNum = array[0]; 
    int maxNum_index = 0; 
    int i;  
 
    for ( i = 1; i < array.Length; ++i) 
        if(maxNum < array[i]) 
        { 
            maxNum = array[i]; 
            maxNum_index = i; 
        } 
        return array[maxNum_index];
}

int MinDigital(int[] array)
{
   int i = 0;
   int minNum = array[0];
   while (i < array.Length)
   {
     if (array[1] < minNum)
     { 
        minNum = array[1];
        i++;
     }
     else minNum = array[0]; 
   } 
   return minNum;
}

void RaznArray(int min, int max)
{
  int result = max - min;
  Console.WriteLine(" Разность " + result);
}