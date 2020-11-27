using Newtonsoft.Json;
using System;
using System.IO;

namespace ParkwayAssessMent
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Please Enter Amount:   ");
            try
            {
                long amount = Int64.Parse(Console.ReadLine());
                CalculateExpectedCharge cal = new CalculateExpectedCharge();
                var charge = cal.ExpectedChardge(amount);
                if (charge < 1)
                {
                    Console.WriteLine($"There is currently no charge for this amount {amount}");
                }
                else
                {
                    Console.WriteLine($"Transaction charge for this amount is: {charge}");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Kindly input a number. Thanks");
                Main(args);
            }
            Console.ReadKey();
        }
       
    }
}
