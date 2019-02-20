using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPstuff.RepositoryPattern {
    public class EmployeeRepository : Repository<Employee> {

        public EmployeeRepository() : base() {
        }
        
        public override IEnumerable<Employee> Find(Func<Employee, bool> predicate) {
            return List
                .Where(predicate)
                .ToList();
        }

        public IEnumerable<Employee> Sort<T>(Func<Employee, T> orderBy) {
            return List
                .OrderBy(orderBy)
                .ToList();
        }

        public void Add(Employee employee) {
            List.Add(employee);
        }
    }
}