using System.Collections.Generic;

namespace OOPstuff.UnitOfWorkPattern {
    public class SaveEmployee : IUnitOfWork {
        private readonly IEnumerable<Employee> _employees;

        public SaveEmployee(IEnumerable<Employee> employees) { // Take DbContext
            _employees = employees;
        } 
        
        public void Commit() {
        }

        public void Dispose() {
        }
    }
}