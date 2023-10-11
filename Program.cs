// See https://aka.ms/new-console-template for more information
using System.Data;
Console.WriteLine("Введите ширину прямоугольника");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длинну прямоугольника");
double b = Convert.ToDouble(Console.ReadLine());
double P = 2 * (a + b);
Console.WriteLine($"Перимертр (P) = {P}");
double S = a * b;
Console.WriteLine($"Площадь (S) = {S}");
double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
Console.WriteLine($"Диагональ (d) = {d}");









