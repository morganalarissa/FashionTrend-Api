using fashionTrend.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier
{
    public sealed record UpdateContractRequest(Guid Id, Guid OrderId, Guid SupplierId, DateTimeOffset StartDate, DateTimeOffset EndDate) : IRequest<UpdateContractResponse>;
}
