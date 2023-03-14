Console.Write("x=");
int x = int.Parse(Console.ReadLine()!);

Console.Write("y=");
int y = int.Parse(Console.ReadLine()!);



void Quarters(int x, int y)
{
    if (x==0||y==0) Console.WriteLine("Error. x=0 or y=0");
   else  if (x > 0 && y > 0) Console.Write("1-я четверть");
   else  if (x < 0 && y > 0) Console.Write("2-я четверть");
   else  if (x < 0 && y < 0) Console.Write("3-я четверть");
   else  if (x > 0 && y < 0) Console.Write("4-я четверть");

}

Quarters(x,y);