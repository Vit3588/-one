Console.WriteLine ("Insert a number of the day of the week: ");
string i = Console.ReadLine();
int a = Convert.ToInt32(i);
if (a == 1)
{
    Console.WriteLine ("This is Monday!");
}
else if (a == 2)
{
    Console.WriteLine ("This is Tuesday!");
}
else if (a == 3)
{
    Console.WriteLine ("This is Wednesday!");
}
else if (a == 4)
{
    Console.WriteLine ("This is Thursday!");
}
else if (a == 5)
{
    Console.WriteLine ("This is Friday!");
}
else if (a == 6)
{
    Console.WriteLine ("This is Saturday!");
}
else if (a == 7)
{
    Console.WriteLine ("This is Sunday!");
}
else
{
    Console.WriteLine ("Тhere are only 7 days in a week, try again!");
}