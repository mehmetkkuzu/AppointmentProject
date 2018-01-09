using CaserGroup.Automotive.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.Interface
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        //CRUD İşlemleri
        bool Add(T data);
        bool Update(T data);
        bool Delete(T data);
        T GetOne(int id);
        List<T> GetBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}
