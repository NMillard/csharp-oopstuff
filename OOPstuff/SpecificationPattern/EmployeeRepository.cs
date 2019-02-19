using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OOPstuff.SpecificationPattern {
    public class EmployeeRepository {

        private readonly IList<Employee> _employees;
        public EmployeeRepository() {
            _employees = EmployeeDataSet.Employees();
        }

        public IQueryable<Employee> Filter(Func<Employee, bool> predicate) {
            return _employees
                .Where(predicate)
                .AsQueryable();
        }

        public IQueryable<Employee> Sort<T>(Func<Employee, T> orderBy) {
            return _employees
                .OrderBy(orderBy)
                .AsQueryable();
        }
    }
}