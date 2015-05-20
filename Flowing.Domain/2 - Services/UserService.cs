using Flowing.Domain.Entities;
using Flowing.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Flowing.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetSomeUsers(IEnumerable<User> users)
        {
            return users.Where(c=>c.Login =="Edu").ToList();
            
        }
    }
}
