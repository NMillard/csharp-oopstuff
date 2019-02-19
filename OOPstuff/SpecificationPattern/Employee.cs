using System;
using System.Linq.Expressions;

namespace OOPstuff.SpecificationPattern {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static Expression<Func<Employee, bool>> IsOld => emp => emp.Age > 30;
    }
}