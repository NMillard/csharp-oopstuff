using OOPstuff.Commons.Policies;
using System;
using System.ComponentModel.DataAnnotations;

namespace OOPstuff.Commons {

    [AttributeUsage(AttributeTargets.Property)]
    class NameValidationAttribute : ValidationAttribute {
        private INameState State { get; set; }

        public NameValidationAttribute() {
            this.State = new InvalidName();
        }

        public bool IsValid(object value) {
            return State.ValidateName(value.ToString()).isValid;
        }
    }
}
