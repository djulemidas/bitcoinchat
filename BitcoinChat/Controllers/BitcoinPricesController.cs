using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using Application.Features.BitcoinPrices.Queries;
using System.Threading.Tasks;

namespace BitcoinChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BitcoinPricesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<BitcoinPricesController> _logger;

        public BitcoinPricesController(ILogger<BitcoinPricesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("range")]
        public async Task<BitcoinPriceRangeViewModel> GetRangeAsync(string startDate, string endDate)
        {
            return await _mediator.Send(new GetBitcoinPricesRangeQuery { StartDate = startDate, EndDate = endDate });
        }
        //[HttpGet]
        //[Route("current")]
        //public IEnumerable<WeatherForecast> Get()
        //{

        //}
    }
}
