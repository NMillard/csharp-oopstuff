using System;
using System.Collections.Generic;
using System.Text;

namespace OOPstuff.Commons.Policies {
    class ValidName : INameState {
        public bool isValid => true;

        public INameState ValidateName(string nameToValidate) => this;
    }
}
