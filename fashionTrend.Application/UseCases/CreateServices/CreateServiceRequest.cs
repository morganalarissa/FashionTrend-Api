using fashionTrend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateSupplier
{
    public sealed record CreateServiceRequest(string Description, bool Delivery, ERequestType RequestType, ESewingMachine SewingMachine, EMaterial Material) : IRequest<CreateServiceResponse>
    {
    }
    
}

