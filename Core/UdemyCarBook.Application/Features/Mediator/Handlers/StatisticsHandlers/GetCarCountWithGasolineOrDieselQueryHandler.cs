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
    public class GetCarCountWithGasolineOrDieselQueryHandler : IRequestHandler<GetCarCountWithGasolineOrDieselQuery, GetCarCountWithGasolineOrDieselQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCarCountWithGasolineOrDieselQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarCountWithGasolineOrDieselQueryResult> Handle(GetCarCountWithGasolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountWithGasolineOrDiesel();
            return new GetCarCountWithGasolineOrDieselQueryResult
            {
                CarCountWithGasolineOrDiesel = value,
            };
        }
    }
}
