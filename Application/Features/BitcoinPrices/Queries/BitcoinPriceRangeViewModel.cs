using System.Collections.Generic;

namespace Application.Features.BitcoinPrices.Queries
{
    public class BitcoinPriceRangeViewModel
    {
        public List<BitcoinDatePriceViewModel> PricesPerDate { get; set; }
    }
}