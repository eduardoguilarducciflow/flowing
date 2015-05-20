using Flowing.Domain.Entities;
using Flowing.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowing.Domain.Services
{
    public interface IUserService : IServiceBase<User>
    {
        IEnumerable<User> GetSomeUsers(IEnumerable<User> users);
    }
}
