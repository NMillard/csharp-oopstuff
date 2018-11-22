using System;
using System.Collections.Generic;
using System.Text;

namespace OOPstuff {

    class MyGeneric<T> {

        public void PrintType() {
            Console.WriteLine(typeof(T));
        }

        public void PrintClassType() {
            Console.WriteLine(GetType());
        }
    }
}
