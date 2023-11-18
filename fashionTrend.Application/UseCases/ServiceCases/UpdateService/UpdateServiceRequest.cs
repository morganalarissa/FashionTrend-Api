using fashionTrend.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier
{
    public sealed record UpdateServiceRequest(Guid Id, string Description, bool Delivery, ERequestType RequestType, List<EMaterial> Materials, List<ESewingMachine> SewingMachines) : IRequest<UpdateServiceResponse>;
}
