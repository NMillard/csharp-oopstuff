namespace OOPstuff.SpecificationPattern {
    
    public interface ISpecification<T> {
        
        ISpecification<T> Criteria(T item);
    }
}