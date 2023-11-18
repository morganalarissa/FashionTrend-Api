using fashionTrend.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier
{
    public sealed record UpdateServiceOrderRequest(Guid Id, Guid SupplierId, Guid ServiceId, DateTimeOffset EstimatedDate, ERequestStatus RequestStatus) : IRequest<UpdateServiceOrderResponse>;
}
