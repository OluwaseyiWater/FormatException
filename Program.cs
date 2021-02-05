using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven = 0;
            double gallonsUsed = 0;

            try
            {
                Console.WriteLine("Please enter miles driven");
                milesDriven = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter gallons used");
                gallonsUsed = Convert.ToDouble(Console.ReadLine());


                double milesPerGallon = milesDriven / gallonsUsed;
                Console.WriteLine("Mileage i {0} miles per gallon", milesPerGallon);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a correct digit!\n{0}", e.Message);
            }
            Console.ReadKey();
           
        }
    }
}
