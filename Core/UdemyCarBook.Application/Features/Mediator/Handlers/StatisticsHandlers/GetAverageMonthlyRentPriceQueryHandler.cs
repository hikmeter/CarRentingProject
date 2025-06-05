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
    public class GetAverageMonthlyRentPriceQueryHandler : IRequestHandler<GetAverageMonthlyRentPriceQuery, GetAverageMonthlyRentPriceQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetAverageMonthlyRentPriceQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAverageMonthlyRentPriceQueryResult> Handle(GetAverageMonthlyRentPriceQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAverageMonthlyRentPrice();
            return new GetAverageMonthlyRentPriceQueryResult
            {
                AverageMonthlyRentPrice = value,
            };
        }
    }
}
