namespace OOPstuff.DirectiveStuff {
    
    [PropertyRequirement(typeof(RequiresCode))]
    public class Animal : IHasName {
        
        public Animal() {
        }
        public string Name { get; }

    }
}