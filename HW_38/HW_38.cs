// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Lenght = PrintDigital("Введите длину массива ");
double[] array = RandomArray(Lenght);
PrintArray(array);
double min = MinDigital(array);
double max = MaxDigital(array);
RaznArray(min, max);

int PrintDigital(string mes)
{
    Console.Write(mes);
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

double[] RandomArray(int Lenght)
{ 
    double[] array = new double[Lenght];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }
    return array;   
} 

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

double MaxDigital(double[] array)
{
    double maxNum = array[0];
    for ( int i = 0; i < array.Length; i++) 
        {
            if(array[i] > maxNum)
            {
               maxNum = array[i];
            }
        }
    return maxNum;
}


double MinDigital(double[] array)
{
   double minNum = array[0];
    for ( int i = 0; i < array.Length; i++) 
        {
            if(array[i] < minNum)
            {
               minNum = array[i];
            }
            
        }
    return minNum;
    
}

void RaznArray(double min, double max)
{
  double result = max - min;
  Console.WriteLine(" Разность " + result);
}