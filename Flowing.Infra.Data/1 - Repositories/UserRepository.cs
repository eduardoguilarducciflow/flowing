using Flowing.Domain.Entities;
using Flowing.Domain.Interfaces.Repositories;

namespace Flowing.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
    }
}