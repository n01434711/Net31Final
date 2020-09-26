using Microsoft.EntityFrameworkCore;
using Net31.Wynnie.FinalExam.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Net31.Wynnie.FinalExam.EntityFrameworkDataAccess
{
    public sealed class GenericRepository<T> : IDataRepository<T> where T : class, IPoco
    {
        private readonly SimpleShopContext _context;

        public GenericRepository()
        {
            _context = new SimpleShopContext();
        }

        public void Add(params T[] items)
        {
            if (items == null || !items.Any()) return;
            items.ToList().ForEach(t => _context.Entry(t).State = EntityState.Added);
            SaveChanges();
        }

        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var navProp in navigationProperties)
            {
                query = query.Include(navProp);
            }
            return query.ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = _context.Set<T>().Where(where);
            foreach (var navProp in navigationProperties)
            {
                query = query.Include(navProp);
            }
            return query.FirstOrDefault();
        }

        public void Update(params T[] items)
        {
            if (items == null || !items.Any()) return;
            items.ToList().ForEach(t => _context.Entry(t).State = EntityState.Modified);
            SaveChanges();
        }

        public void Remove(params T[] items)
        {
            if (items == null || !items.Any()) return;
            items.ToList().ForEach(t => _context.Entry(t).State = EntityState.Deleted);
            SaveChanges();
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
