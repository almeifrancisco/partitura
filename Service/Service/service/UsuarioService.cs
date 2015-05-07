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
        UnitOfWork unit;
        public UsuarioService(UnitOfWork unit)
        {
            this.unit = unit;
            repo = new UsuarioRepositorio(this.unit);


        }


        public string CadastroDeUsuario(Usuario usuario)
        {
            
            PasswordManager PwManage = new PasswordManager();
            string salt = null;
            string passwordHash = PwManage.GeneratePasswordHash(usuario.senha , out salt);
            usuario.codS = salt;
            usuario.senha = passwordHash;
            usuario.fk_endereco = 4;
            usuario.data_cadastro = DateTime.Now;
            usuario.nivel = "a";
            

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
            repo.Insert(entity);
            return entity.id;
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
