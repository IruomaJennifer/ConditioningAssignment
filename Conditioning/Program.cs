using System;

namespace Conditioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 5
            //what kind of root does the equation X^2 + 6X + 5 = 0 have?
            //b^2-4ac>0(real roots), <0(complex roots), =0(equal roots)
            NotDynamicConditioning();

            //Assignment 6
            DynamicConditioning();

        }

        private static void DynamicConditioning()
        {
            Console.WriteLine("Input a number for A, press enter to continue");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a number for B, press enter to continue");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a number for C, press enter to continue");
            double c = double.Parse(Console.ReadLine());
            var checkCriteria = Math.Pow(b, 2) - 4 * a * c;
            string kindOfRoot;
            if (checkCriteria > 0)
            {
                kindOfRoot = "Real";
                Console.WriteLine(kindOfRoot + " Roots");
            }
            else if (checkCriteria < 0)
            {
                kindOfRoot = "Complex";
                Console.WriteLine(kindOfRoot + " Roots");
            }
            else if (checkCriteria == 0)
            {
                kindOfRoot = "Equal";
                Console.WriteLine(kindOfRoot + " Roots");
            }
        }

        private static void NotDynamicConditioning()
        {
            Console.WriteLine("What kind of root does the equation X^2 + 6X + 5 = 0 have?");
            int a = 1;
            int b = 6;
            int c = 5;
            var checkCriteria = (b ^ 2) - 4 * a * c;
            string kindOfRoot;
            if (checkCriteria > 0)
            {
                kindOfRoot = "Real";
                Console.WriteLine(kindOfRoot + " Roots");
            }
            else if (checkCriteria < 0)
            {
                kindOfRoot = "Complex";
                Console.WriteLine(kindOfRoot + " Roots");
            }
            else if (checkCriteria == 0)
            {
                kindOfRoot = "Equal";
                Console.WriteLine(kindOfRoot + " Roots");
            }
        }
    }
}
