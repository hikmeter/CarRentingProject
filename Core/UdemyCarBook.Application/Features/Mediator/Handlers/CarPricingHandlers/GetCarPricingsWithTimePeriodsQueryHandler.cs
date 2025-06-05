using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingsWithTimePeriodsQueryHandler : IRequestHandler<GetCarPricingsWithTimePeriodsQuery, List<GetCarPricingsWithTimePeriodsQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        public GetCarPricingsWithTimePeriodsQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }
        public Task<List<GetCarPricingsWithTimePeriodsQueryResult>> Handle(GetCarPricingsWithTimePeriodsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingsWithTimePeriods();
            var result = values.Select(x => new GetCarPricingsWithTimePeriodsQueryResult
            {
                BrandModel = x.BrandModel,
                CoverImageUrl = x.CoverImageUrl,
                DailyAmount = x.DailyAmount,
                MonthlyAmount = x.MonthlyAmount,
                WeeklyAmount = x.WeeklyAmount
            }).ToList();
            return Task.FromResult(result);
        }
    }
}
