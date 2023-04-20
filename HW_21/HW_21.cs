// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки А - X1 ");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки А - Y1 ");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки А - Z1 ");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B - X12");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B - Y2 ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B - Z2 ");
double Z2 = double.Parse(Console.ReadLine());
double answer = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
Console.WriteLine(Math.Round(answer, 5));