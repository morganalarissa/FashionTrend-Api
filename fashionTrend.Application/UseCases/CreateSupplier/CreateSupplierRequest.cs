using fashionTrend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateSupplier
{
    public sealed record CreateSupplierRequest(string Name, string Email, string Password, EMaterial Material, ESewingMachine SewingMachine) : IRequest<CreateSupplierResponse>
    {
    }
    
}

