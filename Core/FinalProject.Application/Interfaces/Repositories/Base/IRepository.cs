
namespace FinalProject.Application.Interfaces.Repositories.Base
{
    public interface IRepository<T> where T : Entity
    {
        Task<ICollection<T>> GetAllAsync(params string[] includes);
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> predicate, params string[] includes);
        Task<T> GetByIdAsync(int id, params string[] includes);
        Task<int> AddAsync(T createModel);
        Task<int> UpdateAsync(T updateModel);
        Task<int> DeleteAsync(int id);
        Task<int> DeleteAsync(T entity);
    }
}
