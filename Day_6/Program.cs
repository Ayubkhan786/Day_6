


int a = 2;
while (a < 10)
{
    double b = (Math.Pow(2, a - 1));
    double c = (Math.Pow(2, a) - 1);
    double d = b * c;
    Console.WriteLine(d);
    a++;
    if ( d%a!=0)
    {
        Console.WriteLine(d+"  : It is Perfect Number");
      
    }
}

