using System.Collections.Generic;
using System.Linq;
using EClothing.Domain.SharedContext.Repository;
using Microsoft.EntityFrameworkCore;

namespace EClothing.Infra.SharedContext
{
    public class RepositoryGeneric<TEntity, TKey> : IRepositoryGeneric<TEntity, TKey> where TEntity : class
    {
        private EClothingContext _context;
        public RepositoryGeneric(EClothingContext eClothing)
        {
            _context = eClothing;
        }      

        public List<TEntity> Get()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(TKey id)
        {
           return _context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity model)
        {
            _context.Set<TEntity>().Add(model);
            _context.SaveChanges();
        }

        public void Update(TEntity model)
        {
            _context.Set<TEntity>().Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }

         public void Delete(TEntity model)
        {
            _context.Set<TEntity>().Attach(model);
            _context.Entry(model).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void DeleteById(TKey id)
        {
            var model = GetById(id);
            Delete(model);
        }
    }
}