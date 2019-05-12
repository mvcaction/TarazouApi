using System.Collections.Generic;
using System.Security.Claims;
using Tarazou4.Entities;

namespace Services
{
    public interface IJwtService
    {
        string Generate(User user);
        IEnumerable<Claim> getclaims(User user);
    }
}