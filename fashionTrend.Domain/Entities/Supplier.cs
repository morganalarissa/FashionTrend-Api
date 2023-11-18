using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionTrend.Domain.Enums;

namespace fashionTrend.Domain.Entities
{
    public sealed class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<EMaterial> Materials { get; set; }
        public List<ESewingMachine> SewingMachines { get; set; }

    }
}
