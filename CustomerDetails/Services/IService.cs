using CustomerDetails.Models;

namespace CustomerDetails.Services
{
    public interface IService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id, bool log = true);
        Task<List<TEntity>> GetAsync();
        Task AddAsync(TEntity entity, bool log = true);
        Task UpdateAsync(TEntity entity, bool log = true);
        Task DeleteAsync(TEntity entity, bool log = true);
    }
}