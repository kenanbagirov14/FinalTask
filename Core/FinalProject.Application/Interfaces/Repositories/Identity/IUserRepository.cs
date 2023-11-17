

namespace FinalProject.Application.Interfaces.Repositories.Identity
{
    public interface IUserRepository : IRepository<User>
    {
        public IQueryable<User> Users { get; }  
    }
}
