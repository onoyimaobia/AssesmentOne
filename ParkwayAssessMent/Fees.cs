using System;
using System.Collections.Generic;
using System.Text;

namespace ParkwayAssessMent
{
    public class Fee
    {
        public int minAmount { get; set; }
        public int maxAmount { get; set; }
        public int feeAmount { get; set; }
    }

    public class Root
    {
        public List<Fee> fees { get; set; }
    }
}
