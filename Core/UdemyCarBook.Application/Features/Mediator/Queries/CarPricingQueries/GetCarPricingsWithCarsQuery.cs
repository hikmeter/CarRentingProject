using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingsWithCarsQuery : IRequest<List<GetCarPricingsWithCarsQueryResult>>
    {
    }
}
