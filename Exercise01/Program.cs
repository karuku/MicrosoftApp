using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The default regular expression checks for at least on digit");
            Console.Write("Please Enter a regular expression (or press enter to use the default): ");
            var inputRE = Console.ReadLine();
            Console.Write("Please Enter an input to compare with: ");
            var inputCW = Console.ReadLine();
             
            Console.WriteLine(string.Format("Your input {0} matches {1} {2}", inputCW, inputRE, DoComparison(inputRE, inputCW)));
            Console.WriteLine("Press <Enter>  to exit... ");
            Console.ReadLine();
        }
        static bool DoComparison(string inputRegExp, string inputCompareWith)
        { 
            var myReg =  "[0-9]";
            try
            {

                if (!string.IsNullOrWhiteSpace(inputRegExp))
                    myReg = inputRegExp;

                var isMatch = Regex.IsMatch(inputCompareWith, myReg);
                 
                return isMatch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
