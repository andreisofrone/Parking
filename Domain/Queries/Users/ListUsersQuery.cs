using Domain.Models;
using MediatR;
using System.Collections.Generic;

namespace Domain.Queries.Users
{
    public class ListUsersQuery : IRequest<IEnumerable<User>>
    {
    }
}