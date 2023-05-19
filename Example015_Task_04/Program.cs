Console.WriteLine("Imput a number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a number 3: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
{
    b = max;
}
if (c > max)
{
    c = max;
}
Console.Write("max=");
Console.WriteLine(max);