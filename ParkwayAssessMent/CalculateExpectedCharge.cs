using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ParkwayAssessMent
{
    public class CalculateExpectedCharge
    {
        public int ExpectedChardge(long amount)
        {
            string datafile = File.ReadAllText(@"..\..\..\fees.config.json");
            Root fees = JsonConvert.DeserializeObject<Root>(datafile);
            int maxi = 0;
            int feeAmount = 0;
            //var fees = JsonConvert.DeserializeObject<Fees>(datafile);
            //const fee = null
            foreach(var fee in fees.fees)
            {
                if (maxi < fee.maxAmount) 
                {
                    maxi = fee.maxAmount;
                    feeAmount = fee.feeAmount;
                }
                if (amount >= fee.minAmount && amount<= fee.maxAmount)
                {
                    
                    return fee.feeAmount;
                }
            }
            if (amount > maxi) return feeAmount;
            return 0;
        }
    }
}
