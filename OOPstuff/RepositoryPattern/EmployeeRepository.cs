using System;
using System.Collections.Generic;
using System.Linq;
using OOPstuff.SpecificationPattern;

namespace OOPstuff.RepositoryPattern {
    public class EmployeeRepository : IRepository<Employee> {
        private readonly IList<Employee> _employees;

        public EmployeeRepository(IList<Employee> employees) {
            _employees = employees;
        }
        
        public void Add(Employee employee) {
            _employees.Add(employee);
        }

        public void Remove(Employee employee) {
            _employees.Remove(employee);
        }

        public IQueryable<Employee> Find(Func<Employee, bool> predicate) {
            return _employees
                .Where(predicate)
                .AsQueryable();
        }
    }
}