Console.WriteLine ("Insert a number a: ");
string i = Console.ReadLine();
int a = Convert.ToInt32(i);
Console.WriteLine ("Insert a number b: ");
string j = Console.ReadLine();
int b = Convert.ToInt32(j);

if (a == b*b)
{
 Console.WriteLine ("The number a is a square of the number b");   
}
else
{
    Console.WriteLine ("The number a IS NOT a square of the number b");
}