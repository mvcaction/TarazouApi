using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarazou4.Entities;

namespace Data.Contracts
{
   public interface IQuestionCategoryRepository : IRepository<QuestionCategory>
    {
       
    }
}
