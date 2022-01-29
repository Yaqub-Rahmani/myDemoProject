using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context mcon = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = mcon.Set<T>();
        }

        public void Delete(T p)
        {
            var DeleteEntity = mcon.Entry(p);
            DeleteEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            mcon.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> Filter)
        {
            return _object.SingleOrDefault(Filter);
        }

        public void Insert(T p)
        {
            var addEntity = mcon.Entry(p);
            addEntity.State = EntityState.Added;
            //_object.Add(p);
            mcon.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();

        }

        public List<T> List(Expression<Func<T, bool>> Filter)
        {
            return _object.Where(Filter).ToList();
        }

        
        public void Update(T p)
        {
            var updatedEntity = mcon.Entry(p);
            updatedEntity.State = EntityState.Modified;
            mcon.SaveChanges();
        }
    }
}
