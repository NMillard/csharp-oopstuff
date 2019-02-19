using System;
using OOPstuff.DirectiveStuff;
using OOPstuff.SpecificationPattern;

namespace OOPstuff {

    class Program {

        static void Main(string[] args) {
            
            var repo = new EmployeeRepository();

            var t = repo.Filter((employee => employee.Age > 23));

            var c = new Context();
            c.LoadWithDirective();
            var te = c.HasName;
            
            Console.ReadLine();
        }
    }
}
