
using Common.Exceptions;
using Common.Utilities;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarazou4.Entities;
using Tarazou4.Data;

namespace Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(tarazouContext dbContext)
            : base(dbContext)
        {
        }

        public Task<User> GetByUserAndPass(string username, string password, CancellationToken cancellationToken)
        {
           // var passwordHash = SecurityHelper.GetSha256Hash(password);
            return Table.Where(p => p.Username == username && p.Password==password).SingleOrDefaultAsync(cancellationToken);
        }

        public Task UpdateSecuirtyStampAsync(User user, CancellationToken cancellationToken)
        {
            //user.SecurityStamp = Guid.NewGuid();
            return UpdateAsync(user, cancellationToken);
        }

        //public override void Update(User entity, bool saveNow = true)
        //{
        //    entity.SecurityStamp = Guid.NewGuid();
        //    base.Update(entity, saveNow);
        //}

        public Task UpdateLastLoginDateAsync(User user, CancellationToken cancellationToken)
        {
            user.LastLoginDate = DateTimeOffset.Now;
            return UpdateAsync(user, cancellationToken);
        }

        public async Task AddAsync(User user, string password, CancellationToken cancellationToken)
        {
            var exists = await TableNoTracking.AnyAsync(p => p.Username == user.Username);
            if (exists)
                throw new BadRequestException("نام کاربری تکراری است");

            var passwordHash = SecurityHelper.GetSha256Hash(password);
            user.Password = passwordHash;
            await base.AddAsync(user, cancellationToken);
        }
    }
}
