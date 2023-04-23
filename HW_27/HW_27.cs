// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int PrintNumber(string mes)
{
    Console.WriteLine(mes);
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

int AllSumma(int number)
{
    int sum = 0;
    while(number > 0)
    {    
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

int number = PrintNumber("Введите число ");
Console.WriteLine(AllSumma(number));