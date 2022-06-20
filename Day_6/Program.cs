using System;

namespace Day_6
{
    public class Functions
    {
        Random random = new Random();

        int[] coupon = new int[7] { 1,5,6,9,7,3,5 };
        
        public void cal()
        {

            int i = 0;
           while ( (i< coupon[i]))
            { 
                if(random.Next(1,10) == coupon[i])
                {
                    
                    Console.WriteLine(coupon[i]);
                    i++;

                }

            }

        }
        static void Main(string[] args)
        {
            Functions functions = new Functions();
            functions.cal();
        }
    }
}
