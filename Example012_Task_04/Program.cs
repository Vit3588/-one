Console.WriteLine("Imput a number: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for (int i = -a; i <= a; i++)
{
    Console.WriteLine(i);
}