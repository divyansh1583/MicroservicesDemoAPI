using MediatR;
using UserService.Application.DTOs;

namespace UserService.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public Guid Id { get; set; }
    }
}
