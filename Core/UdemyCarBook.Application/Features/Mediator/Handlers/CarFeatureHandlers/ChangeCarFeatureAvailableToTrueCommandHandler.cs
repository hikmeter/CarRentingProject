using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class ChangeCarFeatureAvailableToTrueCommandHandler : IRequestHandler<ChangeCarFeatureAvailableToTrueCommand>
    {
        private readonly ICarFeatureRepository _repository;
        public ChangeCarFeatureAvailableToTrueCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public async Task Handle(ChangeCarFeatureAvailableToTrueCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCarFeatureAvailableToTrue(request.Id);
        }
    }
}
