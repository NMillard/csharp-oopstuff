using System;

namespace OOPstuff.DirectiveStuff {
    
    [AttributeUsage(AttributeTargets.Class)]
    public class PropertyRequirement : Attribute {
        
        public PropertyRequirement(Type requirement) {
            Requirement = requirement as IRequirement;
        }

        public IRequirement Requirement { get; private set; }

        public bool IsCodeRequired { get; }
    }
}