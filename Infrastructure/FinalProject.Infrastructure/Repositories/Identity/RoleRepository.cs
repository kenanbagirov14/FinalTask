using FinalProject.Application.Interfaces.Repositories.Identity;
using FinalProject.Domain.Entities.Identity;


namespace FinalProject.Infrastructure.Repositories.Identity
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
        }
    }
}
