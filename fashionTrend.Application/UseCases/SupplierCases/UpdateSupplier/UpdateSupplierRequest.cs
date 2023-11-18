using fashionTrend.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier
{
    public sealed record UpdateSupplierRequest(Guid Id, string Name, string Email, string Password, EMaterial Material, ESewingMachine SewingMachine) : IRequest<UpdateSupplierResponse>;
}
