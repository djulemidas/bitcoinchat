using Application.Common.Models;
using RestEase;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ICoindeskApi
    {
        [Get("historical/close.json")]
        Task<BitcoinPricesRangeDto> GetBitcoinPricesRange([Query] string startDate, [Query] string endDate);

        [Get("currentprice.json")]
        Task<BitcoinCurrentPriceDto> GetCurrentBitcoinPrice([Query] string startDate, [Query] string endDate);
    }
}