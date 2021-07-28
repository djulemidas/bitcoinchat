using System;
using System.Collections.Generic;

namespace Application.Common.Models
{
    public class BitcoinPricesRangeDto
    {
        public Dictionary<DateTime, double> Bpi { get; set; }
        public string Disclaimer { get; set; }
        public BitcoinPriceTimeDto Time { get; set; }
    }
}