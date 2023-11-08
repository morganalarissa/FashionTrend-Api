using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using fashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T: BaseEntity
    {
        //implementar a interface IbaseRepository que fornecerá os métodos base definidos na interface

        //no construtor vamos encapsular o contexto de banco de dados
        protected readonly AppDbContext Context;
        public BaseRepository(AppDbContext context) 
        {
            // injetar a instancia do contexto ao construtor
            Context = context;
        }

        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.Now;
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.DateDeleted = DateTimeOffset.Now;
            Context.Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(
                x => x.Id.Equals(id), cancellationToken);
        }

        public async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }

        public void Update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.Now;
        }
    }
}
