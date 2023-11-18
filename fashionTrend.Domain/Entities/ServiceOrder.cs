using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionTrend.Domain.Enums;

namespace fashionTrend.Domain.Entities
{
    public sealed class ServiceOrder : BaseEntity
    {    
        public Guid SupplierId{ get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public ERequestStatus RequestStatus { get; set; }

    }
}
