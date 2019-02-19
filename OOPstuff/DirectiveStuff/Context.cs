using System;
using System.Linq;
using System.Reflection;

namespace OOPstuff.DirectiveStuff {
    public class Context {

        public IHasName HasName { get; private set; }
        
        public void LoadWithDirective() {
            var type = typeof(IHasName);
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => type.IsAssignableFrom(t));

            foreach (var concreteType in types) {
                var props = concreteType.GetProperties();
                var attributes = concreteType.GetCustomAttributes(typeof(PropertyRequirement));

                foreach (var attribute in attributes) {
                    var att = attribute as PropertyRequirement;
                    
                    if (att.IsCodeRequired) {
                        HasName = Activator.CreateInstance(concreteType) as IHasName;
                    }
                }
            }
        }
    }
}