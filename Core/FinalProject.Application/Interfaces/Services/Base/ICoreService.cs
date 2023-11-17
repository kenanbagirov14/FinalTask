using FinalProject.Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Interfaces.Services.Base
{
    public interface ICoreService<TEntity,TView,TAdd,TUpdate,TDelete> where TEntity : Entity where TView : BaseDTO where TAdd : BaseDTO where TUpdate : BaseDTO where TDelete : BaseDTO
    {
        Task<ICollection<TView>> GetAllAsync();
        Task<TUpdate> GetByIdAsync(int id);
        Task<int> AddAsync(TAdd createModel);
        Task<int> UpdateAsync(TUpdate updateModel);
        Task<int> DeleteAsync(int id);
        Task<int> DeleteAsync(TDelete entity);
    }
}
