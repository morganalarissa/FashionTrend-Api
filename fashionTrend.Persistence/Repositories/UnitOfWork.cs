using fashionTrend.Domain.Interfaces;
using fashionTrend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Repositories
{
    // responsabilidade: gerenciar as transações e o commit das operações de BD
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;   // representação do banco de dados
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            //esse metodo vai comitar se salvar as alterações no BD
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
