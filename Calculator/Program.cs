using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //set purchase price of house
            
            int purchasePrice = int.Parse(Console.ReadLine());
            double stampDuty = CalculatorHelp.Calculate(purchasePrice);
            //call function to work out stamp duty
            Console.WriteLine(stampDuty);
            Console.ReadKey();
        }
    }
}
