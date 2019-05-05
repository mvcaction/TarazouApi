using Entities;
using System.Threading.Tasks;
using Tarazou4.Entities;

namespace Services
{
    public interface IJwtService
    {
        string Generate(User user);
        Task<string> GenerateAsync(User user);

    }
}