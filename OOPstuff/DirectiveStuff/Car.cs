namespace OOPstuff.DirectiveStuff {
    
    [PropertyRequirement(isCodeRequired: false)]
    public class Car : IHasName {
        public Car() {
        }

        public string Name { get; }
    }
}