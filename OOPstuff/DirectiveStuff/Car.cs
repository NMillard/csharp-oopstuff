namespace OOPstuff.DirectiveStuff {
    
    [PropertyRequirement(typeof(RequiresNoCode))]
    public class Car : IHasName {
        public Car() {
        }

        public string Name { get; }
    }
}