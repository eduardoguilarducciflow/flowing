using Flowing.Domain.Entities;
using System.Collections.Generic;

namespace Flowing.Application.Interfaces
{
    public interface IUserApplicationService : IApplicationServiceBase<User>
    {
        IEnumerable<User> GetSomeUsers();
    }
}
