using System;
using System.Collections.Generic;

namespace Application.Common.Models
{
    public class BitcoinPricesRangeDto
    {
        public Dictionary<DateTime, float> Bpi { get; set; }
        public string Disclaimer { get; set; }
        public BitcoinPriceTimeDto Time { get; set; }
    }
}