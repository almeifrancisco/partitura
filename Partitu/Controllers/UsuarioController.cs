using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.service;
using Repositorio.repo;
using Repositorio.unityOfWork;
using Partitu.Models;

namespace Partitu.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult UsuarioCadastro()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult UsuarioCadastro(Usuario usuario)
        {

           
            UnitOfWork unit = new UnitOfWork();

            UsuarioService serUser = new UsuarioService(unit);
        
            if (ModelState.IsValid)        
            {   
                Repositorio.Usuario user = trocarUser(usuario);
                serUser.CadastroDeUsuario(user);

                return RedirectToAction("index", "home");
            }
            return View(usuario); 
        }



        public  Repositorio.Usuario trocarUser(Usuario user)
        {
            Repositorio.Usuario usuario = new Repositorio.Usuario();
            usuario.nome = user.nome;
            usuario.cpf = user.cpf;
            usuario.data_nascimento = user.data_nascimento;
            usuario.email = user.email;
            usuario.senha = user.senha;


            return usuario;
        }
    }
}
