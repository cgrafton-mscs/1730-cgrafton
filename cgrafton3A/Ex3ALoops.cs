using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgrafton3A
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();

        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyIntrestRate)
        {
            double futurevalue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlypayment = double.Parse(strMonthlyPayment);
                double monthlyinterestrate = double.Parse(strMonthlyIntrestRate);
                int i = 1;
                while (i <= months)
                {
                    futurevalue = (futurevalue + monthlypayment) * (1 + monthlyinterestrate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }

            return futurevalue.ToString("n2");
        }

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyIntrestRate)
        {
            double futurevalue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlypayment = double.Parse(strMonthlyPayment);
                double monthlyinterestrate = double.Parse(strMonthlyIntrestRate);
                int i = 1;
                do
                {
                    futurevalue = (futurevalue + monthlypayment) * (1 + monthlyinterestrate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }

            return futurevalue.ToString("n2");
        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyIntrestRate)
        {
            double futurevalue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlypayment = double.Parse(strMonthlyPayment);
                double monthlyinterestrate = double.Parse(strMonthlyIntrestRate);
                for (int i = 1; i <= months; i++)
                {
                    futurevalue = (futurevalue + monthlypayment) * (1 + monthlyinterestrate);
                }
            }
            catch
            {
                return "Invalid input";
            }

            return futurevalue.ToString("n2");

        }

        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int i = start;
                while (i < end)
                {
                    result += i + " ";
                    i += increment;
                }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int i = start;
                do
                {
                    result += i + " ";
                    i += increment;
                }
                while (i < end);
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                for (int i = start; i < end; i += increment)
                {
                    result += i + " ";
                }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;

            try
            {

                int count = Int32.Parse(strCount);
                int i = 1;
                while (i <= count)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    number += sum;

                    startIndex = endIndex + 1;
                    i++;
                }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }
    }
}
