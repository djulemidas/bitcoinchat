using System;
using System.Collections.Generic;

namespace Application.Common
{
    public class BitcoinPricesRangeDto
    {
        public Dictionary<DateTime, double> Bpi { get; set; }
        public string Disclaimer { get; set; }
        public BitcoinPriceTime Time { get; set; }

    }
}