using System;

namespace Day_6
{
    public class Newton
    {

        public void sqrt()
        {

            Console.WriteLine("Newton's method SquareRoot ");


            double c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            Console.WriteLine("The Initial value of t : " + t);

            double Avg = c / t;

            if (Math.Abs(t - c / t) > 1e-15 * t)
            {
                t = (t + Avg) / 2;
            }

            Console.WriteLine("The Desired value of t :" + t);

        }
        static void Main(string[] args)
        {
            Newton S = new Newton();
            S.sqrt();
        }
    }
}
