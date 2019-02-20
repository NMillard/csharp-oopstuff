using System;

namespace OOPstuff.UnitOfWorkPattern {
    public interface IUnitOfWork : IDisposable {
        void Commit();
    }
}