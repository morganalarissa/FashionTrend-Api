using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Entities
{
    public sealed class Contract : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid SupplierId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

    }
}
