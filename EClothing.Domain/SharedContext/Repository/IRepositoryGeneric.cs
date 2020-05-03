using System.Collections.Generic;

namespace EClothing.Domain.SharedContext.Repository
{
    public interface IRepositoryGeneric<TEntity, TKey> where TEntity : class
    {
        List<TEntity> Get();

        TEntity GetById(TKey id);

        void Insert(TEntity model);

        void Update(TEntity model);

        void Delete(TEntity model);
        void DeleteById(TKey id);  
    }
}