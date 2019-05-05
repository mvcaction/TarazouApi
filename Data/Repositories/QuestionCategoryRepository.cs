using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data.Contracts;
using Microsoft.EntityFrameworkCore;
using Tarazou4.Data;
using Tarazou4.Entities;

namespace Data.Repositories
{
   public class QuestionCategoryRepository : Repository<QuestionCategory>, IQuestionCategoryRepository
    {
        public QuestionCategoryRepository(tarazouContext dbContext)
               : base(dbContext)
        {
        }




        public async Task AddAsync(QuestionCategory questioncategoty, CancellationToken cancellationToken)
        {


            await base.AddAsync(questioncategoty, cancellationToken);
        }
        public async Task GetQuestionCategory(int id, CancellationToken cancellationToken)
        {


        }
    }
}
