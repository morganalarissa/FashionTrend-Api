using fashionTrend.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.ServiceCases.CreateServices
{
    public sealed record CreateServiceRequest(string Description, bool Delivery, ERequestType RequestType, List<ESewingMachine> SewingMachines, List<EMaterial> Materials) : IRequest<CreateServiceResponse>
    {
    }

}

