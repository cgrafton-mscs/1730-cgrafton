using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgrafton2G
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            // 1A) Switch with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;

            }

            return discountPercent.ToString("0.0");

        }
        public static string If01(string customerType)
        {
            // 1B) Seperate 'if' statements
            decimal discountPercent = -1m;


            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;

            return discountPercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            // 1C) If ElseIf
            decimal discountPercent = -1m;


            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;

            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse01(string customerType)
        {
            // 1D) Nested If-Else
            decimal discountPercent = -1m;


            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
            }
            

            return discountPercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customerType)
        {
            // 1E) 'Switch' w/ default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = 0m;
                    break;

            }

            return discountPercent.ToString("0.0");

        }
        public static string IfDefault01(string customerType)
        {
            // 1F) Seperate 'if' statements, default
            decimal discountPercent = -1m;


            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType != "R" && customerType != "C")
                discountPercent = 0m;

            return discountPercent.ToString("0.0");
        }
        public static string ElseIfDefault01(string customerType)
        {
            // 1G) If ElseIf w/ default
            decimal discountPercent = -1m;


            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            else
                discountPercent = 0m;

            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElseDefault01(string customerType)
        {
            // 1H) Nested If-Else w/ default
            decimal discountPercent = -1m;


            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                    discountPercent = 0m;
            }


            return discountPercent.ToString("0.0");
        }

        public static string Switch02(string customerType)
        {
            // 2a) 'Switch' with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                case "C":
                    discountPercent = .2m;
                    break;
                case "T":
                    discountPercent = .4m;
                    break;

            }
            return discountPercent.ToString("0.0");
        }
        public static string If02(string customerType)
        {
            // 2B) Separate 'if' statements
            decimal discountPercent = -1m;


            if (customerType == "R" || customerType == "C")
                discountPercent = .2m;
            if (customerType == "T")
                discountPercent = .4m;

            return discountPercent.ToString("0.0");
        }
        public static string ElseIf02(string customerType)
        {
            // 2C) If ElseIf
            decimal discountPercent = -1m;

            if (customerType == "R" || customerType == "C")
                discountPercent = .2m;
            else if (customerType == "T")
                discountPercent = .4m;
            else
                discountPercent = -1m;


            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse02(string customerType)
        {
            // 2D) Nested If-Else
            decimal discountPercent = -1m;
            

            if (customerType == "R" || customerType == "C")
            {
                discountPercent = .2m;
            }
            else
            {
                if (customerType == "T")
                {
                    discountPercent = .4m;
                }
                else
                    discountPercent = -1m;
            }


            return discountPercent.ToString("0.0");
        }
    }
}
