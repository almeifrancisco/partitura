using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;
namespace Repositorio
{
    public interface IBaseRepositorio<T>
    {

        T Single(object primaryKey);
        Dictionary<string, string> GetAuditNames(dynamic dynamicObject);
        T SingleOrDefault(object primaryKey);
        IEnumerable<T> GetAll();
        bool Exists(object primaryKey);
        int Insert(T entity);
        void Update(T entity);
        int Delete(T entity);

        IUnitOfWork UnitOfWork { get; }

    }
}
