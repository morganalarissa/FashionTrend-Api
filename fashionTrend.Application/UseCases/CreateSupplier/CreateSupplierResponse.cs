using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateSupplier
{
    public sealed record CreateSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public EMaterial Material { get; set; }
        public ESewingMachine SewingMachine { get; set; }
        //public string Password { get; set; }
    }
}
