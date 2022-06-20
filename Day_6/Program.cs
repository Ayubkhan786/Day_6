using System;

namespace Day_6
{
    public class EMI
    {

        public void MonthlyPayment()
        {

            Console.WriteLine("Monthly Payment");


            Console.WriteLine("Principal Amount");

            double P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Years");

            double Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rate of Interest");

            double R = Convert.ToInt32(Console.ReadLine());


            double n = 12 * Y;
            double r = R / (12 * 100);

            double Payment = ((P * r) / (1 - (Math.Pow((1 + r), (-n)))));

            Console.WriteLine(Payment);
        }
        static void Main(string[] args)
        {
            EMI Payment = new EMI();
            Payment.MonthlyPayment();
        }
    }
}