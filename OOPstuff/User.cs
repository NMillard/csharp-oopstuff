using OOPstuff.Commons;
using OOPstuff.Commons.Policies;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPstuff {

    class User {

        public string Name { get; private set; }

        /// <summary>
        /// Set a user's name.
        /// This might thrown an exception.
        /// </summary>
        /// <param name="name">Name to give user</param>
        /// <exception cref="Exception">Throws exception</exception>
        public void SetName(string name) {
            INameState state = new InvalidName();

            if (state.ValidateName(name).isValid) {
                this.Name = name;
                return;
            };

            throw new Exception();
        }
    }
}
