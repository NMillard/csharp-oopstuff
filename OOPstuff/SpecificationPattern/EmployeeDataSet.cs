using System.Collections.Generic;

namespace OOPstuff.SpecificationPattern {
    public static class EmployeeDataSet {

        public static IList<Employee> Employees() {
            return new List<Employee> {
                new Employee {Name = "Nicklas", Age = 27},
                new Employee {Name = "Emma", Age = 22},
                new Employee {Name = "Jim", Age = 50},
                new Employee {Name = "Pops", Age = 72},
                new Employee {Name = "Lolly", Age = 12},
                new Employee {Name = "Dejean", Age = 32},
            };
        }
    }
}