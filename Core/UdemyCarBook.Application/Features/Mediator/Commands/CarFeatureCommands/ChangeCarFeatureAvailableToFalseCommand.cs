using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class ChangeCarFeatureAvailableToFalseCommand : IRequest
    {
        public int Id { get; set; }
        public ChangeCarFeatureAvailableToFalseCommand(int id)
        {
            Id = id;
        }
    }
}
