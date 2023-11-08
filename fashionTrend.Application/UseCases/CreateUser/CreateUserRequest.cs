using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Name, string Email, string Password) : IRequest<CreateUserResponse>
    {
    }
}
