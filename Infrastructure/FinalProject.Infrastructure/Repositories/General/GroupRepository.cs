
namespace FinalProject.Infrastructure.Repositories.General
{
    public class GroupRepository : Repository<Group>,IGroupRepository
    {
        public GroupRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
        }
    }
}
