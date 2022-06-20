using System;
namespace Day_6
{
    public class temperatureConversion
    {
        public void farhenheit()
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("Give a Value to Convert it Into  Farhenheit");
            double FC = Convert.ToDouble(Console.ReadLine());
            double CF = (FC * 9 / 5) + 32;
            Console.WriteLine("celsius to Fahrenheit :" + CF);
        }
        public void celsius()
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("Give a Value to Convert it Into celsius");
            double CF1 = Convert.ToDouble(Console.ReadLine());
            double FC1 = (CF1 - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit to celsius :" + FC1);
        }

        static void Main(string[] args)
        {
            temperatureConversion TempCon = new temperatureConversion();
            TempCon.celsius();
            TempCon.farhenheit();
        }
    }
}