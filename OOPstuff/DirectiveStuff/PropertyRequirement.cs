using System;

namespace OOPstuff.DirectiveStuff {
    
    [AttributeUsage(AttributeTargets.Class)]
    public class PropertyRequirement : Attribute {
        
        public PropertyRequirement(bool isCodeRequired) {
            IsCodeRequired = isCodeRequired;
        }

        public bool IsCodeRequired { get; }
    }
}