using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Data.Entity;
using Repositorio.repo;
using Repositorio;
using Repositorio.unityOfWork;
using Service.service.seguranca;
namespace Service.service
{
    public class UsuarioService : IService<Usuario>
    {



        UsuarioRepositorio repo;
        DbSet db;
        IUnitOfWork unit;
        public UsuarioService()
        {
            unit = new UnitOfWork();
            repo = new UsuarioRepositorio(unit);
            db = repo.UnitOfWork.Db.Set<Usuario>();

        }


        public string CadastroDeUsuario(Usuario usuario)
        {
            PasswordManager PwManage = new PasswordManager();
            string salt = null;
            string passwordHash = PwManage.GeneratePasswordHash(usuario.senha , out salt);

            //Validar

            Insert(usuario);
            return salt;
        }


        public Usuario Single(object primaryKey)
        {
            Usuario user = repo.Single(primaryKey);
            return user;

        }


        public Dictionary<string, string> GetAuditNames(dynamic dynamicObject)
        {
            throw new NotImplementedException();
        }

        public Usuario SingleOrDefault(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public int Insert(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
