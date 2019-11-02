using CursoMVCUdemy.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CursoMVCUdemy.Repository
{
    public class Repository<T> : IDisposable where T : class
    {
        ContextApp _context;
        DbSet<T> _dbSet;

        public Repository(ContextApp pContext)
        {
            _context = pContext;
            _dbSet = pContext.Set<T>();
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }

        //public void Commit ()
        //{
        //    _context.SaveChanges();
        //}

        public void Edit (T pEntity)
        {
            _context.Entry(pEntity).State = EntityState.Modified;
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> FindBy (Expression<Func<T, bool>> pPredicate)
        {
            return _dbSet.Where(pPredicate);
        }

        public T FindByID (int pID)
        {
            return _dbSet.Find(pID);
        }

        public void Remove (T pEntity)
        {
            _context.Set<T>().Remove(pEntity);
        }

        public void Add(T pEntity)
        {
            _context.Set<T>().Add(pEntity);
        }
    }
}