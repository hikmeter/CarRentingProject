using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetAverageDailyRentPriceQueryHandler : IRequestHandler<GetAverageDailyRentPriceQuery, GetAverageDailyRentPriceQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetAverageDailyRentPriceQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAverageDailyRentPriceQueryResult> Handle(GetAverageDailyRentPriceQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAverageDailyRentPrice();
            return new GetAverageDailyRentPriceQueryResult
            {
                AverageDailyRentPrice = value,
            };
        }
    }
}
