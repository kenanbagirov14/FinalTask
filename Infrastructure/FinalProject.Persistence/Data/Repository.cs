using FinalProject.Application.Exeption;
using FinalProject.Domain.Interfaces;

namespace FinalProject.Persistence.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly FinalProjectDbContext _dbContext;
        protected DbSet<TEntity> _entities => _dbContext.Set<TEntity>();

        public Repository(FinalProjectDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public virtual async Task<int> AddAsync(TEntity createModel)
        {
            await _entities.AddAsync(createModel);
            return await _dbContext.SaveChangesAsync(true);
        }

        public virtual async Task<int> DeleteAsync(int id)
        {

            _entities.Remove(await GetByIdAsync(id));
            return await _dbContext.SaveChangesAsync(true);
        }

        public virtual async Task<int> DeleteAsync(TEntity entity)
        {
            _entities.Remove(entity);
            return await _dbContext.SaveChangesAsync(true);
        }

        public virtual async Task<ICollection<TEntity>> GetAllAsync(params string[] includes)
        {

            if (includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    await _entities.Include(include).LoadAsync();
                }
            }
           
            var result = await _entities.ToListAsync();
            return result;
        }

        public virtual async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, params string[] includes)
        {

            if (includes.Length > 0)
            {
                foreach (var include in includes)
                {
                   await _entities.Include(include).LoadAsync();
                }
            }
            var result = await _entities.Where(predicate).ToListAsync();
            return result;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id, params string[] includes)
        {
            if (includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    _entities.Include(include);
                }
            }
            var result = await _entities.FindAsync(id);
            if (result is null)
            {
                throw new CustomApplicationExeption("Entity not found");
            }
            return result;
        }

        public virtual async Task<int> UpdateAsync(TEntity updateModel)
        {
            _entities.Update(updateModel);
           // _dbContext.Entry(updateModel).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync(true); ;
        }
    }
}
