using Entities;
using Tarazou4.Entities;

namespace Services
{
    public interface IJwtService
    {
        string Generate(User user);
    }
}