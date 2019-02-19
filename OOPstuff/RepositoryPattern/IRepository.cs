using System;
using System.Linq;
using System.Linq.Expressions;

namespace OOPstuff.RepositoryPattern {
    public interface IRepository<T> {
        
        void Add(T entity);
        void Remove(T entity);
        IQueryable<T> Find(Func<T, bool> predicate);
    }
}