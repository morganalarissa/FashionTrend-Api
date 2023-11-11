using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public sealed record CreateServiceOrdersResponse
    {
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public ERequestStatus RequestStatus { get; set; }
    }
}
