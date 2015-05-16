using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace Service.service
{
    interface IService<T>
    {

        T Single(object primaryKey);
        Dictionary<string, string> GetAuditNames(dynamic dynamicObject);
        T SingleOrDefault(object primaryKey);
        IEnumerable<T> GetAll();
        bool Exists(object primaryKey);
        int Insert(T entity);
        void Update(T entity);
        int Delete(T entity);
        

        
        

    }
}
