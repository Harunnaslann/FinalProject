using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FinalProject.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
