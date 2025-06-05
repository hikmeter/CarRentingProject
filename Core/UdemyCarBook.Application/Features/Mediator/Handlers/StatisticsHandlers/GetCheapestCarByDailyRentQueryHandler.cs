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
    public class GetCheapestCarByDailyRentQueryHandler : IRequestHandler<GetCheapestCarByDailyRentQuery, GetCheapestCarByDailyRentQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCheapestCarByDailyRentQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCheapestCarByDailyRentQueryResult> Handle(GetCheapestCarByDailyRentQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCheapestCarByDailyRent();
            return new GetCheapestCarByDailyRentQueryResult
            {
                CheapestCarByDailyRent = value,
            };
        }
    }
}
