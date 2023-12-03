using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Entities
{
    public class DraftContract :BaseEntity
    {
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public string Description { get; set; }
        public bool Accepted { get; set; }
    }
}
