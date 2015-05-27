using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.service;
using Repositorio.repo;
using Repositorio.unityOfWork;
using Partitu.Models;
using Service.service.seguranca;
using Repositorio;
using System.Text.RegularExpressions;

namespace Partitu.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/
       
        public ActionResult UsuarioCadastro()
        {
            UsuarioModel usuario = new UsuarioModel();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult UsuarioCadastro(UsuarioModel usuario)
        {

            
            UsuarioService serUser = new UsuarioService();
            

            if(serUser.Exists(usuario.email))
            {
                ModelState.AddModelError("email", "já existe um usuário cadastrado com esse email.");

            }
        
        
        
            if (ModelState.IsValid)
            {
                Repositorio.Usuario user = trocarUser(usuario);
                
                string msg = serUser.CadastroDeUsuario(user);
                if(string.IsNullOrEmpty(msg)) return RedirectToAction("index", "home");
                ViewBag.msg = msg;
                return View(usuario);
            }
            return View(usuario); 
        }



        public  Repositorio.Usuario trocarUser(UsuarioModel user)
        {
            Repositorio.Usuario usuario = new Repositorio.Usuario();
            usuario.nome = user.nome;
            usuario.cpf = user.cpf;
            usuario.data_nascimento = user.data_nascimento;
            usuario.email = user.email;
            usuario.senha = user.senha;
            usuario.foto = user.foto;
            usuario.sobreNome = user.sobreNome;
            usuario.vendedor = user.vendedor;

            return usuario;
        }

        public void adicionarFoto()
        {
        }
    }
}
