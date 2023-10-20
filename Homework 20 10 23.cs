double S = 0;
for (double i = 0; i <= 1; i += 0.001)
{
    S = S + Math.Cos(Math.Pow(2 * i,2));
}
Console.WriteLine(S);


double H = 0;
for (double i = 1; i>=0; i -= 0.001)
{
    H += Math.Cos(i);
}
Console.WriteLine(H);