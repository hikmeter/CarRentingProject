using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetCarCount")]
        public IActionResult GetCarCount()
        {
            var values = _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }
        [HttpGet("GetLocationCount")]
        public IActionResult GetLocationCount()
        {
            var values = _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAuthorCount")]
        public IActionResult GetAuthorCount()
        {
            var values = _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogCount")]
        public IActionResult GetBlogCount()
        {
            var values = _mediator.Send(new GetBlogCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandCount")]
        public IActionResult GetBrandCount()
        {
            var values = _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAverageDailyRentPrice")]
        public IActionResult GetAverageDailyRentPrice()
        {
            var values = _mediator.Send(new GetAverageDailyRentPriceQuery());
            return Ok(values);
        }
        [HttpGet("GetAverageWeeklyRentPrice")]
        public IActionResult GetAverageWeeklyRentPrice()
        {
            var values = _mediator.Send(new GetAverageWeeklyRentPriceQuery());
            return Ok(values);
        }
        [HttpGet("GetAverageMonthlyRentPrice")]
        public IActionResult GetAverageMonthlyRentPrice()
        {
            var values = _mediator.Send(new GetAverageMonthlyRentPriceQuery());
            return Ok(values);
        }
        [HttpGet("GetAutomaticTransmissionCarCount")]
        public IActionResult GetAutomaticTransmissionCarCount()
        {
            var values = _mediator.Send(new GetAutomaticTransmissionCarCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandWithMostCars")]
        public IActionResult GetBrandWithMostCars()
        {
            var values = _mediator.Send(new GetBrandWithMostCarsQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogWithMostComments")]
        public IActionResult GetBlogWithMostComments()
        {
            var values = _mediator.Send(new GetBlogWithMostCommentsQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountWithLessThan10000Km")]
        public IActionResult GetCarCountWithLessThan10000Km()
        {
            var values = _mediator.Send(new GetCarCountWithLessThan10000KmQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountWithGasolineOrDiesel")]
        public IActionResult GetCarCountWithGasolineOrDiesel()
        {
            var values = _mediator.Send(new GetCarCountWithGasolineOrDieselQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountElectricFuel")]
        public IActionResult GetCarCountElectricFuel()
        {
            var values = _mediator.Send(new GetCarCountElectricFuelQuery());
            return Ok(values);
        }
        [HttpGet("GetMostExpensiveCarByDailyRent")]
        public IActionResult GetMostExpensiveCarByDailyRent()
        {
            var values = _mediator.Send(new GetMostExpensiveCarByDailyRentQuery());
            return Ok(values);
        }
        [HttpGet("GetCheapestCarByDailyRent")]
        public IActionResult GetCheapestCarByDailyRent()
        {
            var values = _mediator.Send(new GetCheapestCarByDailyRentQuery());
            return Ok(values);
        }
    }
}
