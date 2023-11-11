using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Entities
{
    public sealed class Service : BaseEntity
    {
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public ERequestType RequestType { get; set; }
        public ESewingMachine SewingMachine { get; set; }
        public EMaterial Material { get; set; }
    }
}
