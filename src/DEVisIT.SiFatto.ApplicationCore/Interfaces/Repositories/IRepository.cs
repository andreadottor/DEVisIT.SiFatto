namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories
{
    using DEVisIT.SiFatto.Domain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<TEntity, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(TPrimaryKey id);

        Task InsertAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TPrimaryKey id);
    }
}
