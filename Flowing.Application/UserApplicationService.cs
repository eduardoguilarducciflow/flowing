using Flowing.Application.Interfaces;
using Flowing.Domain.Interfaces.Services;
using Flowing.Domain.Entities;
using System.Collections.Generic;



namespace Flowing.Application
{
    public class UserApplicationService : ApplicationServiceBase<User>, IUserApplicationService
    {
        private readonly IUserApplicationService _userService;

        public UserApplicationService(IUserApplicationService userService)
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
