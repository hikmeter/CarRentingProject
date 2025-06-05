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
    public class GetCarCountWithLessThan10000KmQueryHandler : IRequestHandler<GetCarCountWithLessThan10000KmQuery, GetCarCountWithLessThan10000KmQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCarCountWithLessThan10000KmQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarCountWithLessThan10000KmQueryResult> Handle(GetCarCountWithLessThan10000KmQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountWithLessThan10000Km();
            return new GetCarCountWithLessThan10000KmQueryResult
            {
                CarCountWithLessThan10000Km = value,
            };
        }
    }
}
