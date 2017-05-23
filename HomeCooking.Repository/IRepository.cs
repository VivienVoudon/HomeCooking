using HomeCooking.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Repository
{
    //public interface IRepository<T> where T : class
    //{
    //    IEnumerable<T> GetAll(Func<T, bool> predicate = null);
    //    T Get(Func<T, bool> predicate);
    //    void Add(T entity);
    //    void Attach(T entity);
    //    void Delete(T entity);
    //}

    public abstract class HCRepository<T> where T : class
    {
        private DbSet<T> _dbSet = null;

        public HCRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                if (predicate != null)
                {
                    return _dbSet.Where(predicate);
                }
            }

            return _dbSet;
        }

        public T Get(Func<T, bool> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
