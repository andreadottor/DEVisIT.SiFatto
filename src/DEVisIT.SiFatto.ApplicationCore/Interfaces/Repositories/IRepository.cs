namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories
{
    using DEVisIT.SiFatto.Domain.Entities;
    using System.Collections.Generic;

    public interface IRepository<TEntity, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(TPrimaryKey id);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TPrimaryKey id);
    }
}
