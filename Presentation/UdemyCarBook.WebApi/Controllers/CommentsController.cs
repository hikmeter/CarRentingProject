using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.CommentCommands;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentsRepository;
        private readonly IMediator _mediator;
        public CommentsController(IGenericRepository<Comment> commentsRepository, IMediator mediator)
        {
            _commentsRepository = commentsRepository;
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentsRepository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentsRepository.Add(comment);
            return Ok("Yorum Eklendi!");
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentsRepository.GetById(id);
            _commentsRepository.Remove(value);
            return Ok("Yorum Silindi!");
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentsRepository.Update(comment);
            return Ok("Yorum Güncellendi!");
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentsRepository.GetById(id);
            return Ok(values);
        }
        [HttpGet("GetCommentsByBlogId")]
        public IActionResult GetCommentsByBlogId(int id)
        {
            var values = _commentsRepository.GetCommentsByBlogId(id);
            return Ok(values);
        }
        [HttpGet("GetCommentCountByBlogId")]
        public IActionResult GetCommentCountByBlogId(int id)
        {
            var value = _commentsRepository.GetCommentCountByBlogId(id);
            return Ok(value);
        }
        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum eklendi!");
        }
    }
}
