namespace OOPstuff.DirectiveStuff {
    
    [PropertyRequirement(isCodeRequired: true)]
    public class Animal : IHasName {
        
        public Animal() {
        }
        public string Name { get; }

    }
}