namespace Application.Common
{
    public class BitcoinCurrentPriceDto
    {
        public BitcoinPriceTime Time { get; set; }
        public string Disclaimer { get; set; }
        public BitcoinPricePerCurrency Bpi { get; set; }

    }
}