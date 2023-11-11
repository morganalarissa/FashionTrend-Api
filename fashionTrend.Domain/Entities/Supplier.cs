using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Entities
{
    public sealed class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EMaterial Material { get; set; }
        public ESewingMachine SewingMachine { get; set; }

    }
}
