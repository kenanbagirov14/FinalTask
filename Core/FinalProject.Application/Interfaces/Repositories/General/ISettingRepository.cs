using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Interfaces.Repositories.General
{
    public interface ISettingRepository : IRepository<Setting>
    {
        Task<Setting> GetSettingAsync();
    }
}
