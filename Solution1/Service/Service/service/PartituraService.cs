using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.repo;
using Repositorio;
using Repositorio.unityOfWork;
namespace Service.service
{
    public class PartituraService: IService<Partitura>
    {
        PartituraRepositorio repo;
        UnitOfWork unit;
        public PartituraService()
        {
            unit = new UnitOfWork();
            repo = new PartituraRepositorio(unit);
        }

        public Partitura Single(object primaryKey)
        {
         
            return  repo.unit._db.Partitura.Where(x => x.id == (int)primaryKey).FirstOrDefault();
             
       }

        public Dictionary<string, string> GetAuditNames(dynamic dynamicObject)
        {

            throw new NotImplementedException();
        }

        public Partitura SingleOrDefault(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Partitura> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public int Insert(Partitura entity)
        {
            return repo.Insert(entity);
        }

        public void Update(Partitura entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Partitura entity)
        {
            throw new NotImplementedException();
        }

        public bool cadastrarPartitura(Partitura partitura, Usuario user)
        {
            //validar
            try
            {

                partitura.fk_vendedor = user.id; 
                Insert(partitura);
                return true;
            }
            catch
            { 
                return false; 
            } 

        }
    }
}
