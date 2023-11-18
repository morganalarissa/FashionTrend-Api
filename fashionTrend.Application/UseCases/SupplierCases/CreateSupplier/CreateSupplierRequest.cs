using fashionTrend.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.CreateSupplier
{
    public sealed record CreateSupplierRequest(string Name, string Email, string Password, List<ESewingMachine> SewingMachines, List<EMaterial> Materials) : IRequest<CreateSupplierResponse>
    {
    }

}

