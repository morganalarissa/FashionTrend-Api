using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using fashionTrend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Repositories
{
    public class ServiceOrderRepository : BaseRepository<ServiceOrder>, IServiceOrderRepository
    {
        public ServiceOrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
