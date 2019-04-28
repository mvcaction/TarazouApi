using System.Threading;
using System.Threading.Tasks;
using Tarazou4.Entities;

namespace Data.Repositories
{
    public interface IQuestionRepository : IRepository<Question>
    {
       //Task<Question> GetByUserAndPass(string username, string password, CancellationToken cancellationToken);

        Task AddAsync(Question question, CancellationToken cancellationToken);
       // Task UpdateSecuirtyStampAsync(Question question, CancellationToken cancellationToken);
      // Task UpdateLastLoginDateAsync(Question question, CancellationToken cancellationToken);
    }
}