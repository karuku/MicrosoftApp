using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class NumberToStringConverter
    {
        private string outputStr = string.Empty;

        public string Towards(long number)
        { 
            long length = number.ToString().Length;
            if (length <= 0)
                return "Invalid number";

            switch (length)
            {
                case 1:
                    outputStr = DefineOnes(number);
                    break;
                case 2:
                    outputStr = DefineTwos(number) == string.Empty ? DefineTwosPart(number) : outputStr;
                    break; 
                default:
                    break;
            }

            if (length > 2)
            {
                switch (length)
                { 
                    case 3:
                        outputStr = DefineOnes(Convert.ToInt64(number.ToString().Substring(0, 1)));
                        outputStr += DefineAboveTwoPartsByLength(length);
                        break;
                    default:
                        break;
                } 
            }
            return outputStr;
        }

        private string DefineOnes(long number)
        {
            var outputStr = string.Empty;
            switch (number)
            {
                case 0:
                    outputStr = "zero";
                    break;
                case 1:
                    outputStr = "one";
                    break;
                case 2:
                    outputStr = "two";
                    break;
                case 3:
                    outputStr = "three";
                    break;
                case 4:
                    outputStr = "four";
                    break;
                case 5:
                    outputStr = "five";
                    break;
                case 6:
                    outputStr = "six";
                    break;
                case 7:
                    outputStr = "seven";
                    break;
                case 8:
                    outputStr = "eight";
                    break;
                case 9:
                    outputStr = "nine";
                    break;
                default:
                    break;
            }
            return outputStr;
        }

        private string DefineTwos(long number)
        {
            switch (number)
            {
                case 10:
                    outputStr = "ten";
                    break;
                case 11:
                    outputStr = "eleven";
                    break;
                case 12:
                    outputStr = "twelve";
                    break;
                case 13:
                    outputStr = "thirteen";
                    break;
                case 15:
                    outputStr = "fifteen";
                    break;
                case 20:
                    outputStr = "twenty";
                    break;
                case 30:
                    outputStr = "thirty";
                    break;
                default:
                    break;
            }
            return outputStr;
        }

        private string DefineTwosPart(long number)
        {
            outputStr = DefineOnes(Convert.ToInt64(number.ToString().Substring(0,1)));
            switch (number)
            {
                case 14:
                case 16:
                case 17:
                case 18:
                case 19:
                    outputStr += " teen";
                    break;
                case 40:
                case 50:
                case 60:
                case 70:
                case 80:
                case 90:
                    outputStr += " ty";
                    break;
            }
            return outputStr;
        }

        private string DefineAboveTwoPartsByLength(long numberLength)
        { 
            switch (numberLength)
            {
                case 3:
                    outputStr = "hundred";
                    break;
                case 4:
                case 5:
                case 6:
                    outputStr = "thousand";
                    break;
                case 7:
                case 8:
                case 9: 
                    outputStr = "million";
                    break;
                case 10:
                case 11:
                case 12: 
                    outputStr = "billion";
                    break;
                case 13:
                case 14:
                case 15: 
                    outputStr = "trillion";
                    break;
                case 16:
                case 17:
                case 18: 
                    outputStr = "quadtrillion";
                    break;
                case 19:
                case 20:
                case 30: 
                    outputStr = "quintrillion";
                    break;
                default:
                    outputStr = "Not Defined";
                    break;
            }
            return outputStr;
        }

    }
}
