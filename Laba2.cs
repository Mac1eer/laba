Console.WriteLine("Введите а, b, с");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
if ((a == c || a == b))
{
    Console.WriteLine("Треугольник равнобедренный");
}
else
{
    Console.WriteLine("Треугольник не равнобедренный");
}


