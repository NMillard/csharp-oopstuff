using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPstuff.RepositoryPattern {
    public class Repository<T> : IRepository<T> {

        protected readonly List<T> List;
        
        public Repository() {
            List = new List<T>();
        }


        public virtual IEnumerable<T> Find(Func<T, bool> predicate) {
            return List
                .Where(predicate)
                .ToList();
        }
    }
}