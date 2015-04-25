using System.Data.Entity;
using System.Transactions;
using Repositorio.Context;
using System.Data.Objects;

namespace Repositorio.unityOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private Repositorio.Context.FirstProjecEntities _db;
         
        public UnitOfWork()
        {
            _db = new Repositorio.Context.FirstProjecEntities();
                    
        }

        public void Dispose()
        {
             
            _transaction.Dispose();
        }

        public void StartTransaction()
        {

            _transaction = new TransactionScope();
        }

        public void Commit()
        {
            _db.SaveChanges();
            _transaction.Complete();
        }


        public DbContext Db
        {
            get { return _db; }
        }
    }
}
