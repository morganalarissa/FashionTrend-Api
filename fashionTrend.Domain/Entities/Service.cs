using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionTrend.Domain.Enums;

namespace fashionTrend.Domain.Entities
{
    public sealed class Service : BaseEntity
    {
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public ERequestType RequestType { get; set; }
        public List<EMaterial> Materials { get; set; }
        public List<ESewingMachine> SewingMachines { get; set; }
    }
}
