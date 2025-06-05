using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAuthorByBlogIdQueryHandler : IRequestHandler<GetAuthorByBlogIdQuery, List<GetAuthorByBlogIdQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetAuthorByBlogIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorByBlogIdQueryResult>> Handle(GetAuthorByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAuthorByBlogId(request.Id);
            return values.Select(x => new GetAuthorByBlogIdQueryResult
            {
                BlogID = x.BlogID,
                AuthorID = x.AuthorID,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
                AuthorName = x.Author.Name,
            }).ToList();
        }
    }
}
