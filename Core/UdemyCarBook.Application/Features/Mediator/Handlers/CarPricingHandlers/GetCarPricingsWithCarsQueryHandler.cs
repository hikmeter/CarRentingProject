using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Application.Features.Mediator.Results.LocationResults;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingsWithCarsQueryHandler : IRequestHandler<GetCarPricingsWithCarsQuery, List<GetCarPricingsWithCarsQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        public GetCarPricingsWithCarsQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarPricingsWithCarsQueryResult>> Handle(GetCarPricingsWithCarsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingsWithCars();
            return values.Select(x => new GetCarPricingsWithCarsQueryResult
            {
                Amount = x.Amount,
                Brand = x.Car.Brand.Name,
                CarPricingID = x.CarPricingID,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model,
                CarID = x.CarID
            }).ToList();
        }
    }
}
