using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.Commands.CreateUser;
using UserService.Application.DTOs;
using UserService.Application.Queries.GetUser;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateUser(CreateUserCommand command)
        {
            var userId = await _mediator.Send(command);
            return Ok(userId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(Guid id)
        {
            var query = new GetUserQuery { Id = id };
            var user = await _mediator.Send(query);
            return user != null ? Ok(user) : NotFound();
        }
    }
}
