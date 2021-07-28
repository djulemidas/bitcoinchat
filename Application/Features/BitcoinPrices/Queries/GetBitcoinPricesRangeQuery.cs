using Application.Common.Interfaces;
using MediatR;
using RestEase;
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
            var api = RestClient.For<ICoindeskApi>("https://api.coindesk.com/v1/bpi");
            var result = await api.GetBitcoinPricesRange(request.StartDate, request.EndDate);

            throw new System.NotImplementedException();
        }
    }
}