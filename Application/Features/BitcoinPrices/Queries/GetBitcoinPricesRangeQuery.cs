using Application.Common.Interfaces;
using MediatR;
using RestEase;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.BitcoinPrices.Queries
{
    public class GetBitcoinPricesRangeQuery : IRequest<BitcoinPriceRangeViewModel>
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class GetBitcoinPricesRangeQueryHandler : IRequestHandler<GetBitcoinPricesRangeQuery, BitcoinPriceRangeViewModel>
    {
        public async Task<BitcoinPriceRangeViewModel> Handle(GetBitcoinPricesRangeQuery request, CancellationToken cancellationToken)
        {
            var results = new BitcoinPriceRangeViewModel
            {
                PricesPerDate = new List<BitcoinDatePriceViewModel>()
            };
            var api = RestClient.For<ICoindeskApi>("https://api.coindesk.com/v1/bpi");
            var result = await api.GetBitcoinPricesRange(request.StartDate, request.EndDate);
            // TODO: Add Automapper
            var dates = result.Bpi.Keys;
            foreach (var date in dates)
            {
                BitcoinDatePriceViewModel priceForDate = new BitcoinDatePriceViewModel
                {
                    Date = date,
                    Price = result.Bpi[date]
                };
                results.PricesPerDate.Add(priceForDate);
            }

            return results;
        }
    }
}