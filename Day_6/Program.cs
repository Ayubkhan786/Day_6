

using System;
namespace Day_6
{


    public class ToBinary
    {
        public void BN()
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
        public int Swap(int x)
        {
           
            return (x & 0x0F) << 4 | (x & 0xF0) >> 4;
        }


            public static void Main(string[] args)
            {
                ToBinary binary = new ToBinary();
                binary.BN();
               binary.Swap(1000);

            }
    }
}



