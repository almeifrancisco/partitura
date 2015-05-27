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



        public UsuarioRepositorio repo;
        UnitOfWork unit;
        public UsuarioService()
        {
            unit = new UnitOfWork();
            repo = new UsuarioRepositorio(this.unit);
        }

        public Usuario getPorEmail(string email)
        {
            return repo.unitOf._db.Usuario.FirstOrDefault(x=>x.email==email); 
        }

        public string CadastroDeUsuario(Usuario usuario)
        {
           
           
            try
            {
                
                PasswordManager PwManage = new PasswordManager();
                string salt = null;
                string passwordHash = PwManage.GeneratePasswordHash(usuario.senha, out salt);
                usuario.codS = salt;
                usuario.senha = passwordHash;
                usuario.data_cadastro = DateTime.Now;
                usuario.nivel = "a";
                
                Insert(usuario);
                return "";

            }
            catch(Exception e)
            {
                return "Não foi possível salvar, verifique se todos os campos estão corretos. Se o erro continuar entre em contato com o suporte.";
            }

            
        }



        public Usuario Single(object primaryKey)
        {
            try
            {
                Usuario user = repo.Single(primaryKey);
                return user;
            }
            catch{
                return null;
            }
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

        public bool Exists(object email)
        {

            Usuario usuario = repo.unitOf._db.Usuario.Where(x => x.email == email.ToString()).FirstOrDefault();
            if (usuario != null) return true;
            else return false;
            
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
