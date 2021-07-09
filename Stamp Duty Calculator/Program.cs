using System;

 /* Returning Buyers
 0 to £125,000 - 0%
 £125,001 to £250,000 - 2%
 £250,001 to £925,000 - 5%
 £925,001 to £1,500,000 - 10%
 £1,500,000 and above - 12% */

namespace StampDutyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //set purchase price of house
            double purchasePrice = 200000;
            double stampDuty1 = CalculatorHelp.Calculator(purchasePrice);
            //call function to work out stamp duty
            Console.WriteLine(stampDuty1);
            Console.ReadKey();
        }
    }
}
