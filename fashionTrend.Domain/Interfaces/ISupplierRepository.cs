using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Interfaces
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
