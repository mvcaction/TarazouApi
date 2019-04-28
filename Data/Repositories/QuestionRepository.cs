
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
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(tarazouContext dbContext)
            : base(dbContext)
        {
        }



        public Task UpdateSecuirtyStampAsync(Question question, CancellationToken cancellationToken)
        {
            //user.SecurityStamp = Guid.NewGuid();
            return UpdateAsync(question, cancellationToken);
        }

        //public override void Update(User entity, bool saveNow = true)
        //{
        //    entity.SecurityStamp = Guid.NewGuid();
        //    base.Update(entity, saveNow);
        //}

      

        public async Task AddAsync(Question question, CancellationToken cancellationToken)
        {
           
           
            await base.AddAsync(question, cancellationToken);
        }
    }
}
