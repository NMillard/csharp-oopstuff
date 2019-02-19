using System;
using System.Linq.Expressions;

namespace OOPstuff.SpecificationPattern {
    public class Specification<T> {
        
        public Expression<Func<T, bool>> Expression { get; set; }

        public Specification(Expression<Func<T, bool>> expression) {
            Expression = expression;
        }

        public bool IsSatisfiedBy(T entity) => Expression.Compile().Invoke(entity);
    }
}