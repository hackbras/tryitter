using ClassLibraryTryitter;

namespace Tryitter.Data
{
    public interface IBaseService<TEntity>
                where TEntity : class, IBase
    {
        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> ReadAsync(int id, bool tracking = true);

        Task<TEntity> UpdateAsync(int id, TEntity updateEntity);

        Task DeleteAsync(int id);
    }
}
