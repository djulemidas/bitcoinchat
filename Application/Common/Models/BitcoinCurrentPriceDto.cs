namespace Application.Common.Models
{
    public class BitcoinCurrentPriceDto
    {
        public BitcoinPriceTimeDto Time { get; set; }
        public string Disclaimer { get; set; }
        public BitcoinPricePerCurrencyDto Bpi { get; set; }
    }
}