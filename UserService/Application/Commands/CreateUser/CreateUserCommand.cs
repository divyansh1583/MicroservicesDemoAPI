using MediatR;
namespace UserService.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
