////Task2
int n = 89;
int c = 70;
int count = 3;
if (n > c)
{
   n -= c;
   count *= n;
   Console.WriteLine(count);
}
else
{
   c -= n;
   Console.WriteLine(c);
}

~~~~~
////Task3
int X = 14;
int Y = 25;
int Z = 12;
if (X > Y)
{
   if (X > Z)
   {
       Console.Write("X boyukdur.");
   }
   else
   {
       Console.Write("Z boyukdur.");
   }
}
else if (Y > Z)
{
   Console.Write("Y boyukdur.");
}
else
{
   Console.Write("Z boyukdur.");
}

~~~~~
////Task4
for (int n = 3 ; n < 10; n++)
{
    if (n % 2 != 0)
    {
        Console.WriteLine(n);
    }
}