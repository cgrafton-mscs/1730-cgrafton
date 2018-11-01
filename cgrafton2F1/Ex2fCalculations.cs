using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgrafton2F1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1:if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            discountPercent = 0m;
            subtotal = decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200)
                discountPercent = 0.2m;
            else if
                (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if
                (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300)
                discountPercent = 0.4m;
            else if
                (subtotal >= 200m)
                discountPercent = 0.3m;
            else if
                (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = decimal.Parse(inputA);
            string customertype = inputB;
            discountPercent = 0m;
            if (customertype == "R")
            {
                if
                (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else         // customertype isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal euthereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                euthereum = 200m * dollars;
                return euthereum.ToString();
            }
                return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal price = 0m;
            decimal quantity = 0m;
            decimal shipping = 0m;
            price = Decimal.Parse(inputA);
            quantity = Decimal.Parse(inputB);
            if
                (price * quantity >= 50m)
                shipping = price * quantity;
            else
                shipping = price * quantity + 5m;

            if (inputA != "" && inputB != "")
                return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            double result = 0.0;
            if (inputA != "" && inputB != "")
            return "Invalid input";
        }
    }
}
