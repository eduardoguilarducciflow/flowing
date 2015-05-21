using Flowing.Domain.Entities;
using Flowing.Domain.Interfaces.Repositories;
using Flowing.Domain.Interfaces.Services;
using Flowing.Domain.Services;
using System.Collections.Generic;
using System.Linq;

namespace Flowing.Domain.Interface.Services
{
    public class TaxService : ServiceBase<User>,ITaxService
    {
        private readonly IUserRepository _userRepository;

        public TaxService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
        public double GetTaxRate()
        {
            List<User> u = new List<User>();
            this.GetSomeUsers(u);
            return 0.7;
        }
        public IEnumerable<User> GetSomeUsers(IEnumerable<User> users)
        {
            return users.Where(c => c.Login == "Edu").ToList();

        }
    }
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetSomeUsers()
        {
            return null;
        }
    }
}
