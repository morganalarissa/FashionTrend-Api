using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionTrend.Domain.Entities;
using MediatR;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public sealed record CreateServiceOrdersRequest(Guid SupplierId, Guid ServiceId, DateTimeOffset EstimatedDate, ERequestStatus RequestStatus) : IRequest<CreateServiceOrdersResponse>
    {
    }
}
