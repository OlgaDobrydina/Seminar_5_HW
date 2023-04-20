// Напишите программу, которая принимает на вход пятизначное
//число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
Console.Write("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine()); 
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int rev1 = number / 10 % 10;
int rev2 = number % 10;
int res = number / 10000;
if (res < 1 || res > 9)
{
    Console.WriteLine(number + " -> " + "Это число не пятизначное");
}
else if  (num1 == rev2 && num2 == rev1)
{
    Console.WriteLine(number + " -> Палиндром");
}
else
{
    Console.WriteLine(number + " -> Не палиндром");
}