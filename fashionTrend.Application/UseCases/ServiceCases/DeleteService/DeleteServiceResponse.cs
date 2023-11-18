using fashionTrend.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
{
    public sealed record DeleteServiceResponse
    {
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public ERequestType RequestType { get; set; }
        public List<EMaterial> Materials { get; set; }
        public List<ESewingMachine> SewingMachines { get; set; }
    }
}
