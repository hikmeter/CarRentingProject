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
    public class GetAverageWeeklyRentPriceQueryHandler : IRequestHandler<GetAverageWeeklyRentPriceQuery, GetAverageWeeklyRentPriceQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetAverageWeeklyRentPriceQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAverageWeeklyRentPriceQueryResult> Handle(GetAverageWeeklyRentPriceQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAverageWeeklyRentPrice();
            return new GetAverageWeeklyRentPriceQueryResult
            {
                AverageWeeklyRentPrice = value,
            };
        }
    }
}
