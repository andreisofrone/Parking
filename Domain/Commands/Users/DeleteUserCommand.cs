using Domain.Communication;
using Domain.Models;
using MediatR;

namespace Domain.Commands.Users
{
    public class DeleteUserCommand : IRequest<Response<User>>
    {
        public int Id { get; private set; }

        public DeleteUserCommand(int id)
        {
            this.Id = id;
        }
    }
}