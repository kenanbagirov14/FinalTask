using FinalProject.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FinalProject.Infrastructure.Services
{
    public class CoreService<TEntity, TView, TAdd, TUpdate, TDelete> : ICoreService<TEntity, TView, TAdd, TUpdate, TDelete> where TEntity : Entity where TView : BaseDTO where TAdd : BaseDTO where TUpdate : BaseDTO where TDelete : BaseDTO
    {
        protected IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;
        public CoreService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<int> AddAsync(TAdd createModel)
        {
            var entity = _mapper.Map<TEntity>(createModel);
            var response = await _repository.AddAsync(entity);
            return response;
        }

        public virtual async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public virtual async Task<int> DeleteAsync(TDelete deleteDTO)
        {
            var entity = _mapper.Map<TEntity>(deleteDTO);
            var response = await _repository.DeleteAsync(entity);
            return response;
        }

        public virtual async Task<ICollection<TView>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            var response = entities.Select(s => _mapper.Map<TView>(s)).ToList();
            return response;
        }

        public virtual async Task<TUpdate> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            var response = _mapper.Map<TUpdate>(result);
            return response;
        }

        public virtual async Task<int> UpdateAsync(TUpdate updateModel)
        {
            var entity = _mapper.Map<TEntity>(updateModel);
            var response = await _repository.UpdateAsync(entity);
            return response;
        }
    }
}
