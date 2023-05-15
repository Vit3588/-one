Console.WriteLine("Imput a number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 == 0 || a / 100 > 9)
{
    Console.WriteLine("This number is not correct");
}
else
{
 int i = a % 10;
Console.WriteLine(i);   
}