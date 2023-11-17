using FinalProject.Application.Interfaces.Repositories.Identity;
using FinalProject.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure.Repositories.Identity
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
        }
    }
}
