using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure.Repositories.General
{
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        public SettingRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Setting> GetSettingAsync()
        {
            var setting = await _entities.FirstOrDefaultAsync();
            return setting;
        }
    }
}