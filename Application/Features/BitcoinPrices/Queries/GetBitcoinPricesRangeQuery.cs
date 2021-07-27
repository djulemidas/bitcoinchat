using MediatR;
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
        public Task<BitcoinPriceRangeViewModel> Handle(GetBitcoinPricesRangeQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
