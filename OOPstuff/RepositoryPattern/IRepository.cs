using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OOPstuff.RepositoryPattern {
    public interface IRepository<T> {
        
        IEnumerable<T> Find(Func<T, bool> predicate);
    }
}