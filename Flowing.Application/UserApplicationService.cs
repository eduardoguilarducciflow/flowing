using Flowing.Application.Interfaces;
using Flowing.Domain.Entities;
using Flowing.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace Flowing.Application
{
    public class UserApplicationService : ApplicationServiceBase<User>, IUserApplicationService
    {
        private readonly IUserService _userService;

        public UserApplicationService(IUserService userService)
            : base(userService)
        {
            _userService = userService;
        }
        
        public IEnumerable<User> GetSomeUsers()
        {
            return _userService.GetSomeUsers();
        }
    }
}
