using System;
using OOPstuff.SpecificationPattern;

namespace OOPstuff {

    class Program {

        static void Main(string[] args) {
            
            var repo = new EmployeeRepository();

            var t = repo.Filter((employee => employee.Age > 23));

            Console.ReadLine();
        }
    }
}
