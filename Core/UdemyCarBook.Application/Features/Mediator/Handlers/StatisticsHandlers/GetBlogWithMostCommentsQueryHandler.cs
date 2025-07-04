﻿using MediatR;
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
    public class GetBlogWithMostCommentsQueryHandler : IRequestHandler<GetBlogWithMostCommentsQuery, GetBlogWithMostCommentsQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetBlogWithMostCommentsQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogWithMostCommentsQueryResult> Handle(GetBlogWithMostCommentsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogWithMostComments();
            return new GetBlogWithMostCommentsQueryResult
            {
                BlogWithMostComments = value,
            };
        }
    }
}
