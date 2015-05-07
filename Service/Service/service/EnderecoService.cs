using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using Repositorio.repo;
using Repositorio;
using Repositorio.unityOfWork;
namespace Service.service
{
    public class EnderecoService : IService<Endereco>
    {
        IUnitOfWork unitOfWork;
        EnderecoRepositorio repo;
        
        public EnderecoService() 
        {
            unitOfWork = new UnitOfWork();
            Usuario usu = new Usuario();
            
            repo = new EnderecoRepositorio(unitOfWork);
                       
        }

        public List<Endereco> GetPorBairro(string bai)
        {

            List<Endereco> EnderecoList = new List<Endereco>();
           var dbset =  repo.UnitOfWork.Db.Set<Endereco>();
           EnderecoList = dbset.Where(x => x.bairro == bai).ToList();
                         
            if (EnderecoList == null) {
                Endereco en = new Endereco() { bairro = "aaaa" };
                EnderecoList.Add(en); }
            return EnderecoList;
        }

        public Endereco Single(object primaryKey)
        {
            return repo.Single(primaryKey);
        }

        public Dictionary<string, string> GetAuditNames(dynamic dynamicObject)
        {
            throw new NotImplementedException();
        }

        public Endereco SingleOrDefault(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Endereco> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public int Insert(Endereco entity)
        {
            repo.Insert(entity);
            return entity.id;
        }

        public void Update(Endereco entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Endereco entity)
        {
            throw new NotImplementedException();
        }
    }
}
