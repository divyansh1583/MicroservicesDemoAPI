using MediatR;
using UserService.Application.DTOs;

namespace UserService.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        // In a real application, you'd inject a repository or database context here
        public Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            // Simulating database retrieval
            var user = new UserDto
            {
                Id = request.Id,
                Username = "johndoe",
                Email = "johndoe@example.com"
            };

            return Task.FromResult(user);
        }
    }
}
