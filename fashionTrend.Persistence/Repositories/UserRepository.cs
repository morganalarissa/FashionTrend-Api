using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using fashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) 
        {

        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(
                x => x.Email.Equals(email), cancellationToken);
        }
    }
}
