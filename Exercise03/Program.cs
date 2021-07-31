using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise02;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Please Enter a whole number: ");
            var input=Console.ReadLine();
            var output = DoConversion(input);
            Console.WriteLine(string.Format("Your number {0} in words is {1}", input, output));
            Console.WriteLine("Press <Enter>  to exit... ");
            Console.ReadLine();
        }
        static string DoConversion(string numberStr)
        {
            long inputNo;
            try
            {
                var tryConvertStr = long.TryParse(numberStr, out inputNo);
                if(!tryConvertStr)
                    Console.WriteLine("Invalid Number");

                var nsc = new NumberToStringConverter();

                var results = nsc.Towards(inputNo);
                if (string.IsNullOrWhiteSpace(results))
                    Console.WriteLine("Unsupported Number Input");

                return results;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Conversion Error";
            }
            
        }
    }
}
