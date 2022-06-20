
using System;
public class ToBinary
{
    public static void Main(string[] args)
    {
        int n, i;
        int[] a = new int[100];
        Console.Write("Type the Number :=> ");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; n > 0; i++)
        {
            a[i] = n % 2;
            n = n / 2;

            Console.Write(a[i]);
        }
    }
}
    
 

 