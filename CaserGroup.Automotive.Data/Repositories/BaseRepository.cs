using CaserGroup.Automotive.Data.DataContext;
using CaserGroup.Automotive.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CaserGroup.Automotive.Data.Models;

namespace CaserGroup.Automotive.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, IEntity
    {
        EntityDbContext db = new EntityDbContext();
        public virtual bool Add(T data)
        {
            try
            {
                db.Set<T>().Add(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //log error
                return false;                
            }
        }

        public virtual bool Delete(T data)
        {
            try
            {
                db.Set<T>().Remove(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //throw;
            }
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return db.Set<T>().Where(predicate).ToList();
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return db.Set<T>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public T GetOne(int id)
        {
            try
            {
                return db.Set<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(T data)
        {
            try
            {
                db.Set<T>().Add(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //throw;
            }
        }
    }
}
