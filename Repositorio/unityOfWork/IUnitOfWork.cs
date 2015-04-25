using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Repositorio.unityOfWork
{
   public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void StartTransaction();
        DbContext Db { get;  }
    }
}
