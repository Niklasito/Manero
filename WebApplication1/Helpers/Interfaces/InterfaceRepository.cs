using Manero.Models.Contexts;
using System.Linq.Expressions;

namespace Manero.Helpers.Interfaces;

public interface InterfaceRepository<TEntity, TDbContext> where TEntity : class where TDbContext : DataContext
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(TEntity entity);
}
