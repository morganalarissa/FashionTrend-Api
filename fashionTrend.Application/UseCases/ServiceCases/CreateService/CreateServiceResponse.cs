using fashionTrend.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.ServiceCases.CreateServices
{
    public sealed record CreateServiceResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public ERequestType RequestType { get; set; }
        public List<EMaterial> Materials { get; set; }
        public List<ESewingMachine> SewingMachines { get; set; }
    }
}
