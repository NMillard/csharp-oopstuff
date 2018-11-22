using System;
using System.Collections.Generic;
using System.Text;

namespace OOPstuff.Commons.Policies {
    class InvalidName : INameState {
        public bool isValid => false;

        public INameState ValidateName(string nameToValidate) {
            if (nameToValidate.Length > 5) {
                return new ValidName();
            }

            return this;
        }
    }
}
