﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCarPricingsWithCarsList()
        {
            var values = await _mediator.Send(new GetCarPricingsWithCarsQuery());
            return Ok(values);
        }
        [HttpGet("GetCarPricingsWithTimePeriods")]
        public async Task<IActionResult> GetCarPricingsWithTimePeriods()
        {
            var values = await _mediator.Send(new GetCarPricingsWithTimePeriodsQuery());
            return Ok(values);
        }
    }
}
