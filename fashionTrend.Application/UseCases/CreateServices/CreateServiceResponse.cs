using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateSupplier
{
    public sealed record CreateServiceResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public ERequestType RequestType { get; set; }
        public ESewingMachine SewingMachine { get; set; }
        public EMaterial Material { get; set; }
    }
}
