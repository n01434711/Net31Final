using Net31.Wynnie.FinalExam.Pocos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Net31.Wynnie.FinalExam.EntityFrameworkDataAccess
{
    public interface IDataRepository<T> where T : IPoco
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}
