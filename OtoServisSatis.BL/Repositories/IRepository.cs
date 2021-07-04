using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OtoServisSatis.BL.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllByInclude(string table);
        T Find(int id);
        T Get(Expression<Func<T, bool>> expression);
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
