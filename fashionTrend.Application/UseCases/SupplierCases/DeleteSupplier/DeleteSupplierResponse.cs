using fashionTrend.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
{
    public sealed record DeleteSupplierResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EMaterial Material { get; set; }
        public ESewingMachine SewingMachine { get; set; }
    }
}
