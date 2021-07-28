using Application.Features.BitcoinPrices.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BitcoinPricesController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private readonly ILogger<BitcoinPricesController> _logger;

        public BitcoinPricesController(ILogger<BitcoinPricesController> logger, IMediator mediator)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("range")]
        public async Task<BitcoinPriceRangeViewModel> GetRangeAsync(string startDate, string endDate)
        {
            return await Mediator.Send(new GetBitcoinPricesRangeQuery { StartDate = startDate, EndDate = endDate });
        }

        //[HttpGet]
        //[Route("current")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //}
    }
}