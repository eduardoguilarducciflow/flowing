
using System.Collections.Generic;
using Flowing.Domain.Entities;

namespace Flowing.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        IEnumerable<User> GetSomeUsers();
    }

    public interface ITaxService
    {
        double GetTaxRate();
    }
}
