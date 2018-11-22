using System;
using System.Collections.Generic;
using System.Text;

namespace OOPstuff.Commons.Policies {
    interface INameState {
        bool isValid { get; }
        INameState ValidateName(string nameToValidate);
    }
}
