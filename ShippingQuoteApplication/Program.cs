using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.WriteLine("Enter package weight: ");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else Console.WriteLine("\nEnter package width: ");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter package height: ");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter package length: ");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            int pkgDimSum = pkgWidth + pkgHeight + pkgLength;

            if (pkgDimSum > 50)
            {
                Console.WriteLine("\n\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\n  Total Cost: ");
            }
                double pkgQuoteCalc = pkgDimSum * pkgWeight / 100; // used double type because I am dividing the int values by 100 to convert to decimal then to money string to print to console
                decimal pkgTotal = Convert.ToDecimal(pkgQuoteCalc); // converting to decimal so that I may format my value to a string type money format
                string shippingCost = String.Format("{0:C}", pkgTotal); // using the "C" (currency format string )

                Console.WriteLine("  -----------\n   " + shippingCost);
                Console.ReadLine();
            }
        }
    }




