using MediatR;
using UserService.Domain;

namespace UserService.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        // In a real application, you'd inject a repository or database context here
        public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Simulating user creation
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = request.Username,
                Email = request.Email
            };

            // In a real application, you'd save the user to the database here

            return Task.FromResult(user.Id);
        }
    }
}
